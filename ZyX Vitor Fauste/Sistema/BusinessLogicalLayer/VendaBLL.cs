using DataAccessLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BusinessLogicalLayer
{
    public class VendaBLL
    {
        VendaDAL dal = new VendaDAL();
        ProdutoBLL produtoBLL = new ProdutoBLL();
        public Response Insert(Venda venda)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Response response = dal.Insert(venda);
                if (!response.HasSuccess)
                {
                    return response;
                }
                foreach (ItemTransacao item in venda.Itens)
                {
                    item.IDTransacao = venda.ID;

                    //Validação da quantidade vendida
                    SingleResponse<Produto> singleProduto = produtoBLL.GetById(item.IDProduto);
                    if (!singleProduto.HasSuccess)
                    {
                        return singleProduto;
                    }
                    if (item.QuantidadeProduto > singleProduto.Item.QuantiaEmEstoque)
                    {
                        return new Response("Quantidade em estoque indisponível.", true);
                    }

                    //Inserir o item da venda no banco
                    Response responseItem = dal.InsertItem(item);
                    if (!responseItem.HasSuccess)
                    {
                        return responseItem;
                    }
                    //Atualização do novo estoque e novo preço no banco de dados
                    double novoEstoque = singleProduto.Item.QuantiaEmEstoque - item.QuantidadeProduto;
                    singleProduto.Item.QuantiaEmEstoque = novoEstoque;
                    Response responseProduto = produtoBLL.Update(singleProduto.Item);
                    if (!responseProduto.HasSuccess)
                    {
                        return responseProduto;
                    }
                }
                scope.Complete();
                return response;
            }


        }
    }
}
