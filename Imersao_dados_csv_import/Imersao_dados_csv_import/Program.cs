using CsvHelper;
using Imersao_dados_csv_import.Context;
using Imersao_dados_csv_import.Models;
using System;
using System.Globalization;
using System.IO;

namespace Imersao_dados_csv_import
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MicroDadosContext())
            {
                var path = "";
                using var reader = new StreamReader(path);
                using var csv = new CsvReader(reader, CultureInfo.CurrentCulture);
                
                //define o separado para os fields de cada linha do csv
                csv.Configuration.Delimiter = ";";
                csv.Configuration.HasHeaderRecord = true;

                csv.Read();
                int num = 1;
                int numCommit = 10000;
                while (csv.Read())
                {
                    var dado = new MicroDado
                    {
                        INSCRICAO = csv.GetField(0),
                        ANO = csv.GetField(1),
                        COD_MUNICIPIO_RESIDENCIA = csv.GetField(2),
                        MUNICIPIO_RESIDENCIA = csv.GetField(3),
                        COD_UF_RESIDENCIA = csv.GetField(4),
                        UF_RESIDENCIA = csv.GetField(5),
                        IDADE = csv.GetField(6),
                        SEXO = csv.GetField(7),
                        ESTADO_CIVIL = csv.GetField(8),
                        COR_RACA = csv.GetField(9),
                        NACIONALIDADE = csv.GetField(10),
                        COD_MUNICIPIO_NASCIMENTO = csv.GetField(11),
                        MUNICIPIO_NASCIMENTO = csv.GetField(12),
                        COD_UF_NASCIMENTO = csv.GetField(13),
                        UF_NASCIMENTO = csv.GetField(14),
                        SITUACAO_CONCLUSAO = csv.GetField(15),
                        ANO_CONCLUIU = csv.GetField(16),
                        ESCOLA = csv.GetField(17),
                        ENSINO = csv.GetField(18),
                        TREINEIRO = csv.GetField(19),
                        COD_ESCOLA = csv.GetField(20),
                        COD_MUNICIPIO_ESC = csv.GetField(21),
                        MUNICIPIO_ESC = csv.GetField(22),
                        COD_UF_ESC = csv.GetField(23),
                        UF_ESC = csv.GetField(24),
                        DEPENDENCIA_ADM_ESCOLA = csv.GetField(25),
                        LOCALIZACAO_ESCOLA = csv.GetField(26),
                        SITUACAO_FUNC_ESCOLA = csv.GetField(27),
                        IND_BAIXA_VISAO = csv.GetField(28),
                        IND_CEGUEIRA = csv.GetField(29),
                        IND_SURDEZ = csv.GetField(30),
                        IND_DEFICIENCIA_AUDITIVA = csv.GetField(31),
                        IND_SURDO_CEGUEIRA = csv.GetField(32),
                        IND_DEFICIENCIA_FISICA = csv.GetField(33),
                        IND_DEFICIENCIA_MENTAL = csv.GetField(34),
                        IND_DEFICIT_ATENCAO = csv.GetField(35),
                        IND_DISLEXIA = csv.GetField(36),
                        IND_DISCALCULIA = csv.GetField(37),
                        IND_AUTISMO = csv.GetField(38),
                        IND_VISAO_MONOCULAR = csv.GetField(39),
                        IND_OUTRA_DEF = csv.GetField(40),
                        IND_GESTANTE = csv.GetField(41),
                        IND_LACTANTE = csv.GetField(42),
                        IND_IDOSO = csv.GetField(43),
                        IND_ESTUDA_CLASSE_HOSPITALAR = csv.GetField(44),
                        IND_SEM_RECURSO = csv.GetField(45),
                        IND_BRAILLE = csv.GetField(46),
                        IND_AMPLIADA_24 = csv.GetField(47),
                        IND_AMPLIADA_18 = csv.GetField(48),
                        IND_LEDOR = csv.GetField(49),
                        IND_ACESSO = csv.GetField(50),
                        IND_TRANSCRICAO = csv.GetField(51),
                        IND_LIBRAS = csv.GetField(52),
                        IND_TEMPO_ADICIONAL = csv.GetField(53),
                        IND_LEITURA_LABIAL = csv.GetField(54),
                        IND_MESA_CADEIRA_RODAS = csv.GetField(55),
                        IND_MESA_CADEIRA_SEPARADA = csv.GetField(56),
                        IND_APOIO_PERNA = csv.GetField(57),
                        IND_GUIA_INTERPRETE = csv.GetField(58),
                        IND_COMPUTADOR = csv.GetField(59),
                        IND_CADEIRA_ESPECIAL = csv.GetField(60),
                        IND_CADEIRA_CANHOTO = csv.GetField(61),
                        IND_CADEIRA_ACOLCHOADA = csv.GetField(62),
                        IND_PROVA_DEITADO = csv.GetField(63),
                        IND_MOBILIARIO_OBESO = csv.GetField(64),
                        IND_LAMINA_OVERLAY = csv.GetField(65),
                        IND_PROTETOR_AURICULAR = csv.GetField(66),
                        IND_MEDIDOR_GLICOSE = csv.GetField(67),
                        IND_MAQUINA_BRAILE = csv.GetField(68),
                        IND_SOROBAN = csv.GetField(69),
                        IND_MARCA_PASSO = csv.GetField(70),
                        IND_SONDA = csv.GetField(71),
                        IND_MEDICAMENTOS = csv.GetField(72),
                        IND_SALA_INDIVIDUAL = csv.GetField(73),
                        IND_SALA_ESPECIAL = csv.GetField(74),
                        IND_SALA_ACOMPANHANTE = csv.GetField(75),
                        IND_MOBILIARIO_ESPECIFICO = csv.GetField(76),
                        IND_MATERIAL_ESPECIFICO = csv.GetField(77),
                        IND_NOME_SOCIAL = csv.GetField(78),
                        COD_MUNICIPIO_PROVA = csv.GetField(79),
                        MUNICIPIO_PROVA = csv.GetField(80),
                        COD_UF_PROVA = csv.GetField(81),
                        UF_PROVA = csv.GetField(82),
                        PRESENCA_CN = csv.GetField(83),
                        PRESENCA_CH = csv.GetField(84),
                        PRESENCA_LC = csv.GetField(85),
                        PRESENCA_MT = csv.GetField(86),
                        COD_PROVA_CN = csv.GetField(87),
                        COD_PROVA_CH = csv.GetField(88),
                        COD_PROVA_LC = csv.GetField(89),
                        COD_PROVA_MT = csv.GetField(90),
                        NOTA_CN = csv.GetField(91),
                        NOTA_CH = csv.GetField(92),
                        NOTA_LC = csv.GetField(93),
                        NOTA_MT = csv.GetField(94),
                        TX_RESPOSTAS_CN = csv.GetField(95),
                        TX_RESPOSTAS_CH = csv.GetField(96),
                        TX_RESPOSTAS_LC = csv.GetField(97),
                        TX_RESPOSTAS_MT = csv.GetField(98),
                        TP_LINGUA = csv.GetField(99),
                        TX_GABARITO_CN = csv.GetField(100),
                        TX_GABARITO_CH = csv.GetField(101),
                        TX_GABARITO_LC = csv.GetField(102),
                        TX_GABARITO_MT = csv.GetField(103),
                        TP_STATUS_REDACAO = csv.GetField(104),
                        NU_NOTA_COMP1 = csv.GetField(105),
                        NU_NOTA_COMP2 = csv.GetField(106),
                        NU_NOTA_COMP3 = csv.GetField(107),
                        NU_NOTA_COMP4 = csv.GetField(108),
                        NU_NOTA_COMP5 = csv.GetField(109),
                        NU_NOTA_REDACAO = csv.GetField(110),
                        ESTUDO_PAI = csv.GetField(111),
                        ESTUDO_MAE = csv.GetField(112),
                        OCUPACAO_PAI = csv.GetField(113),
                        OCUPACAO_MAE = csv.GetField(114),
                        PESSOAS_RESIDENCIA = csv.GetField(115),
                        RENDA_FAMILIAR = csv.GetField(116),
                        EMPREGADO_DOMESTICO = csv.GetField(117),
                        BANHEIRO = csv.GetField(118),
                        QUARTOS = csv.GetField(119),
                        CARRO = csv.GetField(120),
                        MOTO = csv.GetField(121),
                        GELADEIRA = csv.GetField(122),
                        FREEZER = csv.GetField(123),
                        MAQ_LAVAR = csv.GetField(124),
                        SECA_ROUPA = csv.GetField(125),
                        MICRO_ONDAS = csv.GetField(126),
                        LAVAR_LOUCA = csv.GetField(127),
                        ASPIRADOR_PO = csv.GetField(128),
                        TV_CORES = csv.GetField(129),
                        DVD = csv.GetField(130),
                        TV_ASSINATURA = csv.GetField(131),
                        CELULAR = csv.GetField(132),
                        TEL_FIXO = csv.GetField(133),
                        COMPUTADOR = csv.GetField(134),
                        INTERNET = csv.GetField(135),

                    };


                    context.MicroDados.Add(dado);
                    Console.WriteLine("Microdado adicionado com sucesso: " + dado.INSCRICAO + " Total: " + num);

                    if (num % numCommit == 0)
                    {
                        context.SaveChanges();
                        Console.WriteLine("COMMIT");
                    }
                    num++;
                }
                context.SaveChanges();
            }
        }
    }
}
