using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabalho1Bim.GD;
using Trabalho1Bim.Models;

namespace Trabalho1Bim.DP
{
    public class CompraFacadeDP
    {
        internal void RealizarCompra(int fornecedorId, int produtoId, int quantidade)
        {
            database1Entities1 context = new database1Entities1();
            ProdutoGD produtoGD = new ProdutoGD(context);

            var produto = produtoGD.RecuperarPorId(produtoId);
            var fornecedor = new FornecedorGD(context).RecuperarPorId(fornecedorId);
            if ((produto.estoque + quantidade) > 1000)
            {
                throw new Exception("quantidade excedida");
            }
            produto.estoque += quantidade;

            produtoGD.Editar(produto);

            Compra compra = new Compra()
            {
                data = DateTime.Now,
                Fornecedor = fornecedor,
            };
            ItemCompra itemCompra = new ItemCompra()
            {
                precoUnitario = produto.precoUnitario,
                quantidade = quantidade,
                Produto = produto,
                Compra = compra
            };
            new CompraGD(context).Adicionar(compra);
            new ItemCompraGD(context).Adicionar(itemCompra);
        }

    }
        
}