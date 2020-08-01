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
    public class Registro0150
    {
        public string codPart { get; set; } // Código de identificação do participante
        public string nome { get; set; } // Nome pessoal ou empresarial
        public string codPais { get; set; } // Código do país do participante
        public string cnpj { get; set; } // CNPJ do participante
        public string cpf { get; set; } // CPF do participante na unidade da federação do destinatário
        public string ie { get; set; } // Inscrição Estadual do participante
        public int codMun { get; set; } // Código do município
        public string suframa { get; set; } // Número de inscrição na Suframa
        public string endereco { get; set; } // Logradouro e endereço do imóvel
        public string num { get; set; } // Número do imóvel
        public string compl { get; set; } // Dados complementares do endereço
        public string bairro { get; set; } // Bairro em que o imóvel está situado
        public IList<Registro0175> registro0175IList;

        public Registro0150()
        {
            registro0175IList = new List<Registro0175>();
        }
    }
}
