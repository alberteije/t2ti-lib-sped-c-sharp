/*******************************************************************************
Title: T2Ti ERP Fenix
Description: Model relacionado ao SPED Fiscal

The MIT License

Copyright: Copyright (C) 2020 T2Ti.COM

* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
* 
* The author may be contacted at: t2ti.com@gmail.com
*
@author Albert Eije (alberteije@gmail.com)
@version 1.0.0
*******************************************************************************/
using System.Collections.Generic;

namespace T2Ti.Lib.Sped.Fiscal
{
    public class RegistroC100
    {
        public string indOper { get; set; } // Indicador do tipo de operação
        public string indEmit { get; set; } // Indicador do emitente do documento fiscal
        public string codPart { get; set; } // Código do participante (campo 02 do Registro 0150)
        public string codMod { get; set; } // Código do modelo do documento fiscal, conforme a Tabela 4.1.1
        public string codSit { get; set; } // Código da situação do documento fiscal, conforme a Tabela 4.1.2
        public string ser { get; set; } // Série do documento fiscal
        public string numDoc { get; set; } // Número do documento fiscal
        public string chvNfe { get; set; } // Chave da Nota Fiscal Eletrônica
        public System.Nullable<System.DateTime> dtDoc { get; set; } // Data da emissão do documento fiscal
        public System.Nullable<System.DateTime> dtES { get; set; } // Data da entrada ou da saída
        public System.Nullable<System.Decimal> vlDoc { get; set; } // Valor total do documento fiscal
        public string indPgto { get; set; } // Indicador do tipo de pagamento
        public System.Nullable<System.Decimal> vlDesc { get; set; } // Valor total do desconto // Prates
        public System.Nullable<System.Decimal> vlAbatNt { get; set; } // Abatimento não tributado e não comercial Ex. desconto ICMS nas remessas para ZFM
        public System.Nullable<System.Decimal> vlMerc { get; set; } // Valor das mercadorias constantes no documento fiscal
        public string indFrt { get; set; } // Indicador do tipo do frete
        public System.Nullable<System.Decimal> vlFrt { get; set; } // Valor do frete indicado no documento fiscal
        public System.Nullable<System.Decimal> vlSeg { get; set; } // Valor do seguro indicado no documento fiscal
        public System.Nullable<System.Decimal> vlOutDa { get; set; } // Valor de outras despesas acessórias
        public System.Nullable<System.Decimal> vlBcIcms { get; set; } // Valor da base de cálculo do ICMS
        public System.Nullable<System.Decimal> vlIcms { get; set; } // Valor do ICMS
        public System.Nullable<System.Decimal> vlBcIcmsSt { get; set; } // Valor da base de cálculo do ICMS substituição tributária
        public System.Nullable<System.Decimal> vlIcmsSt { get; set; } // Valor do ICMS retido por substituição tributária
        public System.Nullable<System.Decimal> vlIpi { get; set; } // Valor total do IPI
        public System.Nullable<System.Decimal> vlPis { get; set; } // Valor total do PIS
        public System.Nullable<System.Decimal> vlCofins { get; set; } // Valor total da COFINS
        public System.Nullable<System.Decimal> vlPisSt { get; set; } // Valor total do PIS retido por substituição tributária
        public System.Nullable<System.Decimal> vlCofinsSt { get; set; } // Valor total da COFINS retido por substituição tributária
        public IList<RegistroC170> registroC170IList { get; set; } // BLOCO C - ILista de RegistroC170 (FILHO)
        public IList<RegistroC190> registroC190IList { get; set; } // BLOCO C - ILista de RegistroC190 (FILHO)

        public RegistroC100()
        {
            registroC170IList = new List<RegistroC170>();
            registroC190IList = new List<RegistroC190>();
        }
    }
}
