

using Pegasus.Business.Implementation;
using System;
using System.Collections.Generic;

using System.Windows.Forms;


namespace Pegasus.Controllers.OrdemServico
{
    public partial class VisualizarOS : Form
    {
        private global::Pegasus.Factory.Entities.OrdemServico ordemServico { get; set; }
        private global::Pegasus.Factory.Entities.Empresa empresa { get; set; }
        public VisualizarOS(global::Pegasus.Factory.Entities.OrdemServico ordemServico)
        {
            InitializeComponent();
            empresa = new Factory.Entities.Empresa();
            empresa = new EmpresaImplementation().BuscarId(1);
            this.ordemServico = ordemServico;

            txt_cliente.Text = ordemServico.cliente.nome;
            txt_combustivel.Text = ordemServico.cliente.veiculos[0].combustivel;
            txt_cor.Text = ordemServico.cliente.veiculos[0].cor;
            txt_defeitoConstatado.Text = ordemServico.defeitoConstatado;
            txt_defeitoRelatado.Text = ordemServico.defeitoRelatado;
            txt_marca.Text = ordemServico.cliente.veiculos[0].marca;
            dtp_entrada.Value = ordemServico.dataInicio;
            dtp_saida.Value = ordemServico.dataFim;
            Decimal total = 0;
            dgv_Produtos.Rows.Clear();
            foreach (global::Pegasus.Factory.Entities.ProdutoVenda v in ordemServico.produtos)
            {
                
                
                foreach (global::Pegasus.Factory.Entities.ProdutoVenda produto in ordemServico.produtos)
                {
                    dgv_Produtos.Rows.Add(produto.id, dgv_Produtos.Rows.Count + 1, produto.produto.descricao, produto.quantidade, produto.produto.precoVendaVista.ToString("C"), (produto.quantidade * produto.produto.precoVendaVista).ToString("C"));
                    total += (produto.produto.precoVendaVista * produto.quantidade);
                }
                lbl_Total.Text = "TOTAL: " + total.ToString("C");
            }
        }

        private void VisualizarOS_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NFe.Classes.NFe tnfe = new NFe.Classes.NFe();
            tnfe.infNFe = new NFe.Classes.Informacoes.infNFe();
            tnfe.infNFe.ide = new NFe.Classes.Informacoes.Identificacao.ide();
            tnfe.infNFe.versao = "3.1";
            tnfe.infNFe.Id = "NFE35120152345732000012550010000002341615359043";
            tnfe.infNFe.ide.tpEmis = NFe.Classes.Informacoes.Identificacao.Tipos.TipoEmissao.teNormal;
            tnfe.infNFe.ide.tpImp = NFe.Classes.Informacoes.Identificacao.Tipos.TipoImpressao.tiNFCe;
            tnfe.infNFe.ide.tpNF = NFe.Classes.Informacoes.Identificacao.Tipos.TipoNFe.tnSaida;
            tnfe.infNFe.ide.verProc = "3.10";
            tnfe.infNFe.ide.procEmi = NFe.Classes.Informacoes.Identificacao.Tipos.ProcessoEmissao.peAplicativoContribuinte;
            tnfe.infNFe.ide.tpAmb = NFe.Classes.Informacoes.Identificacao.Tipos.TipoAmbiente.taHomologacao;
            tnfe.infNFe.ide.cDV = 2;
            tnfe.infNFe.ide.cMunFG = 3545605;
            tnfe.infNFe.ide.cNF = "0001";
         //   tnfe.infNFe.ide.cUF = 
            tnfe.infNFe.ide.dEmi = DateTime.UtcNow;
            tnfe.infNFe.ide.dhEmi = DateTime.Now;
            tnfe.infNFe.ide.dhSaiEnt = DateTime.Now;
            tnfe.infNFe.ide.dSaiEnt = DateTime.Now;
            tnfe.infNFe.ide.finNFe = NFe.Classes.Informacoes.Identificacao.Tipos.FinalidadeNFe.fnNormal;
            tnfe.infNFe.ide.idDest = NFe.Classes.Informacoes.Identificacao.Tipos.DestinoOperacao.doInterna;
            tnfe.infNFe.ide.indFinal = NFe.Classes.Informacoes.Identificacao.Tipos.ConsumidorFinal.cfConsumidorFinal;
            tnfe.infNFe.ide.indPag = NFe.Classes.Informacoes.Identificacao.Tipos.IndicadorPagamento.ipVista;
            tnfe.infNFe.ide.indPres = NFe.Classes.Informacoes.Identificacao.Tipos.PresencaComprador.pcNao;
           // tnfe.infNFe.ide.mod = 
            tnfe.infNFe.ide.natOp = "venda";
            tnfe.infNFe.ide.NFref = null;
            tnfe.infNFe.ide.verProc = "1.0";





             tnfe.infNFe.dest = new NFe.Classes.Informacoes.Destinatario.dest(NFe.Classes.Servicos.Tipos.VersaoServico.ve310);
             //Destinatario
             tnfe.infNFe.dest.email = ordemServico.cliente.email;
             tnfe.infNFe.dest.enderDest = new NFe.Classes.Informacoes.Destinatario.enderDest();
             tnfe.infNFe.dest.enderDest.CEP = ordemServico.cliente.cep.Replace(',', ' ').Replace('-', ' ').Replace(" ", "");
             tnfe.infNFe.dest.enderDest.nro = ordemServico.cliente.numero.ToString();
             tnfe.infNFe.dest.enderDest.fone = long.Parse(ordemServico.cliente.telefone[0].telefone.Replace('(', ' ').Replace(')', ' ').Replace('-', ' ').Replace(" ", ""));
             tnfe.infNFe.dest.enderDest.xPais = "BRASIL";
             tnfe.infNFe.dest.enderDest.cPais = 1058;
             tnfe.infNFe.dest.enderDest.cMun = 3545605;
             tnfe.infNFe.dest.xNome = ordemServico.cliente.nome;
             if(ordemServico.cliente.pessoaJuridica)
             {
                 tnfe.infNFe.dest.CNPJ = ordemServico.cliente.cpfCnpj;

             }
             else
             {
                 tnfe.infNFe.dest.CPF = ordemServico.cliente.cpfCnpj;
             }

              //Emitente
              tnfe.infNFe.emit = new NFe.Classes.Informacoes.Emitente.emit();
              tnfe.infNFe.emit.xFant = empresa.nomeFantasia;
              tnfe.infNFe.emit.xNome = empresa.razaoSocial;
              tnfe.infNFe.emit.IE = empresa.IE.Replace(',', ' ').Trim();
              tnfe.infNFe.emit.CNPJ= empresa.CNPJ;
              tnfe.infNFe.emit.CRT = NFe.Classes.Informacoes.Emitente.CRT.SimplesNacional;
              tnfe.infNFe.emit.enderEmit = new NFe.Classes.Informacoes.Emitente.enderEmit();
              tnfe.infNFe.emit.enderEmit.CEP = empresa.CEP.Replace(',', ' ').Replace('-', ' ').Replace(" ", "");
              tnfe.infNFe.emit.enderEmit.cMun= 3545605;
              tnfe.infNFe.emit.enderEmit.cPais =1058;
              tnfe.infNFe.emit.enderEmit.nro = empresa.numero.ToString();
              tnfe.infNFe.emit.enderEmit.UF = "SP";
              tnfe.infNFe.emit.enderEmit.xBairro = empresa.bairro;
              tnfe.infNFe.emit.enderEmit.xLgr = empresa.endereco;
              tnfe.infNFe.emit.enderEmit.xCpl = empresa.complemento;
              tnfe.infNFe.emit.enderEmit.xMun = empresa.cidade;
              tnfe.infNFe.emit.enderEmit.xPais = "1058";
              tnfe.infNFe.emit.enderEmit.fone = long.Parse(empresa.telefone.Replace('(', ' ').Replace(')', ' ').Replace('-', ' ').Replace(" ", ""));

              int x = 1;
            decimal totalIcms = 0m;
            decimal totalCofins = 0m;
            decimal total = 0m;
            decimal totalProdutos = 0m; 
              tnfe.infNFe.det = new List<NFe.Classes.Informacoes.Detalhe.det>();
              foreach (global::Pegasus.Factory.Entities.ProdutoVenda pv in ordemServico.produtos)
              {
                  NFe.Classes.Informacoes.Detalhe.det det = new NFe.Classes.Informacoes.Detalhe.det();
                  det.nItem = x;
                  det.prod = new NFe.Classes.Informacoes.Detalhe.prod();
                  det.prod.cProd = "5102";
                  det.prod.cEAN = pv.produto.codigoBarras;
                  det.prod.xProd = pv.produto.descricao;
                  det.prod.NCM = "40161010";
                  det.prod.EXTIPI = "15";
                  det.prod.CFOP = 5102;
                  det.prod.uCom = "und";
                  det.prod.qCom = pv.quantidade;
                  det.prod.vUnCom = pv.produto.precoVendaVista;
                  det.prod.vProd = (pv.produto.precoVendaVista * pv.quantidade);
                  det.prod.cEANTrib = pv.produto.codigoBarras;
                  det.prod.uTrib = "und";
                  det.prod.qTrib = pv.quantidade;
                  //  tnfe.infNFe.det[x - 1].prod.vUnTrib = pv.produto.precoVendaVista.ToString();
                  //  tnfe.infNFe.det[x - 1].prod.vFrete = pv.produto.precoFrete.ToString();
                  det.prod.indTot = NFe.Classes.Informacoes.Detalhe.IndicadorTotal.ValorDoItemCompoeTotalNF;

                  //  tnfe.infNFe.det[x - 1].imposto = new TNFeInfNFeDetImpostoICMS();

                  //  tnfe.infNFe.det[x - 1].imposto.PIS = new TNFeInfNFeDetImpostoPIS();
                  //  tnfe.infNFe.det[x - 1].imposto.PIS.Item = TNFeInfNFeDetImpostoPISPISAliq()

                  NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.ICMSSN101 icms01=  new NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.ICMSSN101();
                  icms01.CSOSN = NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.Tipos.Csosnicms.Csosn101;
                  icms01.orig = NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.Tipos.OrigemMercadoria.OmNacional;
                  icms01.pCredSN = 1.25m;
                  icms01.vCredICMSSN = pv.produto.precoVendaVista * 1.25m / 100;
                  det.imposto = new NFe.Classes.Informacoes.Detalhe.Tributacao.imposto();
                  det.imposto.ICMS = new NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.ICMS();
                  det.imposto.COFINSST = new NFe.Classes.Informacoes.Detalhe.Tributacao.Federal.COFINSST();
                  det.imposto.COFINSST.pCOFINS = 0m;
                  det.imposto.COFINSST.qBCProd = pv.quantidade;
                  det.imposto.COFINSST.vAliqProd = ((pv.quantidade * pv.produto.precoVendaVista) / 100) * 0m;
                  det.imposto.COFINSST.vBC = pv.produto.precoVendaVista;

                 det.imposto.ICMS = new NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.ICMS();
                 det.imposto.ICMS.TipoICMS = icms01;
                det.imposto.vTotTrib = ((pv.quantidade * pv.produto.precoVendaVista) / 100) * 0m + icms01.vCredICMSSN;
                  tnfe.infNFe.det.Add(det);
                totalIcms += icms01.vCredICMSSN;
                totalCofins += ((pv.quantidade * pv.produto.precoVendaVista) / 100) * 0m;
                total += ((pv.quantidade * pv.produto.precoVendaVista) / 100) * 0m + pv.produto.precoVendaVista * 1.25m / 100 + (pv.produto.precoVendaVista * pv.quantidade);
                totalProdutos = pv.produto.precoVendaVista * pv.quantidade;
            }

            tnfe.infNFe.total = new NFe.Classes.Informacoes.Total.total();
            tnfe.infNFe.total.ICMSTot = new NFe.Classes.Informacoes.Total.ICMSTot();
            tnfe.infNFe.total.ICMSTot.vBC = 0;
            tnfe.infNFe.total.ICMSTot.vBCST = 1.25m;
            tnfe.infNFe.total.ICMSTot.vCOFINS = totalCofins;
            tnfe.infNFe.total.ICMSTot.vDesc = 0m;
            tnfe.infNFe.total.ICMSTot.vFCPUFDest = 0;
            tnfe.infNFe.total.ICMSTot.vFrete = 0;
            tnfe.infNFe.total.ICMSTot.vICMS = 0;
            tnfe.infNFe.total.ICMSTot.vICMSDeson = 0;
            tnfe.infNFe.total.ICMSTot.vICMSUFDest = 0;
            tnfe.infNFe.total.ICMSTot.vICMSUFRemet = 0;
            tnfe.infNFe.total.ICMSTot.vII = 0;
            tnfe.infNFe.total.ICMSTot.vIPI = 0;
            tnfe.infNFe.total.ICMSTot.vNF = total;
            tnfe.infNFe.total.ICMSTot.vOutro = 0;
            tnfe.infNFe.total.ICMSTot.vPIS = 0;
            tnfe.infNFe.total.ICMSTot.vProd = totalProdutos;
            tnfe.infNFe.total.ICMSTot.vSeg = 0;
            tnfe.infNFe.total.ICMSTot.vST = totalIcms;
            tnfe.infNFe.total.ICMSTot.vTotTrib = totalIcms + totalCofins;

            MessageBox.Show(NFe.Utils.NFe.ExtNFe.ObterXmlString(tnfe));

            SaveFileDialog d = new SaveFileDialog();
            d.ShowDialog();
            d.Filter = ".xml | .XML";
            d.InitialDirectory = "C:\\";
            System.IO.StreamWriter file = new System.IO.StreamWriter(d.FileName);
            file.WriteLine(NFe.Utils.NFe.ExtNFe.ObterXmlString(tnfe));

            file.Close();
             
        }
    }
}
