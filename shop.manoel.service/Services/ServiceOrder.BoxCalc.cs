using shop.manoel.shared.Models;
using shop.manoel.shared.Models.Request;

namespace shop.manoel.service.Services
{
    public partial class ServiceOrder
    {
        public Box ProductBoxCalc(ProductRequestCollection products, List<Box> boxes)
        {
            foreach (var box in boxes)
            {
                // Testar se todos os products cabem na box em todas as orientações possíveis (empilhamento)
                if (ProductBoxCalc(products, box))
                    return box;
            }
            return new Box() { observacao = "Os Produtos não cabe em nenhuma das caixa disponível  em nenhuma das combinação : Altura ou Largura ou Comprimento." };
        }

        public bool ProductBoxCalc(ProductRequestCollection produtos, Box box)
        {
            // Testar se os products cabem na box em todas as orientações possíveis (empilhamento)
            // Por exemplo, podemos empilhar os products em uma das três dimensões: largura, altura ou comprimento

            // 1. Empilhando pela largura
            int totalLargura = produtos.Sum(p => p.dimensoes.largura);
            int maxAltura = produtos.Max(p => p.dimensoes.altura);
            int maxComprimento = produtos.Max(p => p.dimensoes.comprimento);

            if (totalLargura <= box.largura && maxAltura <= box.altura && maxComprimento <= box.comprimento)
            {
                return true;
            }

            // 2. Empilhando pela altura
            int totalAltura = produtos.Sum(p => p.dimensoes.altura);
            int maxLargura = produtos.Max(p => p.dimensoes.largura);
            maxComprimento = produtos.Max(p => p.dimensoes.comprimento);

            if (maxLargura <= box.largura && totalAltura <= box.altura && maxComprimento <= box.comprimento)
            {
                return true;
            }

            // 3. Empilhando pelo comprimento
            int totalComprimento = produtos.Sum(p => p.dimensoes.comprimento);
            maxLargura = produtos.Max(p => p.dimensoes.largura);
            maxAltura = produtos.Max(p => p.dimensoes.altura);

            if (maxLargura <= box.largura && maxAltura <= box.altura && totalComprimento <= box.comprimento)
            {
                return true;
            }

            // Nenhuma das orientações funcionou
            return false;
        }
    }
}
