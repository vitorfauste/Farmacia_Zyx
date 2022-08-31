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
    public class CompraBLL
    {
        CompraDAL dal = new CompraDAL();
        ProdutoBLL produtoBLL = new ProdutoBLL();
        public Response Insert(Compra compra)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Response response = dal.Insert(compra);
                if (!response.HasSuccess)
                {
                    return response;
                }
                foreach (ItemTransacao item in compra.Itens)
                {
                    item.IDTransacao = compra.ID;


                    SingleResponse<Produto> singleProduto = produtoBLL.GetById(item.IDProduto);
                    double novoEstoque = singleProduto.Item.QuantiaEmEstoque + item.QuantidadeProduto;

                    //Cálculo do novo preço do produto, após a compra
                    double precoAtualizado = ((singleProduto.Item.ValorUnitario * singleProduto.Item.QuantiaEmEstoque) + (item.ValorUnitario * novoEstoque)) / (novoEstoque + singleProduto.Item.QuantiaEmEstoque);

                    //Inserir o item da compra no banco
                    Response responseItem = dal.InsertItem(item);
                    if (!responseItem.HasSuccess)
                    {
                        return responseItem;
                    }

                    //Atualização do novo estoque e novo preço no banco de dados
                    singleProduto.Item.ValorUnitario = precoAtualizado;
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
