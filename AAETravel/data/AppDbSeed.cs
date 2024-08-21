using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AAETravel.Models;

namespace AAETravel.Data;

public class AppDbSeed
{
        public AppDbSeed(ModelBuilder builder)
        {
                #region Experiencia
                List<Experiencia> experiencias = new(){
            new Experiencia() {
                    Id = 1,
                    Nome = "Natureza",
                    Foto = "/img/experiencias/natureza.png",
                    Cor = "#00BF63",
                    Fundo = "/img/experiencias/natureza.png",
                    Onda = "/img/outros/paralax/preto-verde.png"

            },
            new Experiencia() {
                    Id = 2,
                    Nome = "Restaurantes",
                    Foto = "/img/experiencias/restaurante.png",
                    Cor = "#E5B712",
                    Fundo = "/img/experiencias/restaurante.png",
                    Onda = "/img/outros/paralax/preto-amarelo.png"


            },
            new Experiencia() {
                    Id = 3,
                    Nome = "Vida Noturna",
                    Foto = "/img/experiencias/vida-noturna.png",
                    Cor = "#A12BA4",
                    Fundo = "/img/experiencias/vida-noturna.png",
                    Onda = "/img/outros/paralax/preto-roxo.png"

            },
            new Experiencia() {
                    Id = 4,
                    Nome = "Espiritualidade",
                    Foto = "/img/experiencias/espiritualidade.png",
                    Cor = "#8A6C47",
                    Fundo = "/img/experiencias/espiritualidade.png",
                    Onda = "/img/outros/paralax/preto-marrom.png"

            },
            new Experiencia() {
                    Id = 5,
                    Nome = "Compras",
                    Foto = "/img/experiencias/compras.png",
                    Cor = "#4B778A",
                    Fundo = "/img/experiencias/compras.png",
                    Onda = "/img/outros/paralax/preto-azul.png"

            },
            new Experiencia() {
                    Id = 6,
                    Nome = "Cultura",
                    Foto = "/img/experiencias/cultura.png",
                    Cor= "#DFD1C6",
                    Fundo = "/img/experiencias/cultura.png",
                    Onda = "/img/outros/paralax/preto-beje.png"

            }
        };
                builder.Entity<Experiencia>().HasData(experiencias);
                #endregion

                List<Agencia> agencias = new(){
                new Agencia() {
                        Id = 1,
                        Nome = "Booking.com",
                        Descricao = "nao sei",
                        Foto = "/img/experiencias/agencias/Booking.png",
                        Link = "https://www.booking.com/?aid=348858&label=gx-br-booking-booking-sd-nhvs",
                        Cor = "#4C8CB7",
                },
                new Agencia() {
                        Id = 2,
                        Nome = "Expedia",
                        Descricao = "nao sei",
                        Foto = "/img/experiencias/agencias/Expedia.png",
                        Link = "https://www.expedia.com.br/?locale=pt_BR&siteid=69&semcid=BR.B.BING.BT-c-PT.GT&semdtl=a1686369326.b11322714033213817.g1kwd-82670466053188.e1c.m1ab46ac5af65f1b662a4dca08af7b5eb5.r184009ff3402fd6a93a30e8f5d7b5a1cca5430f54f9df56f741e2a4a84089cfd9.c1Cm6dAowtvW27WbJtvR_5Vw.j1147720.k1.d182669875489872.h1e.i1.l1.n1.o1.p1.q1.s1.t1.x1.f1.u1.v1.w1&msclkid=ab46ac5af65f1b662a4dca08af7b5eb5",
                        Cor = "#E4C34E",
                },
                new Agencia() {
                        Id = 3,
                        Nome = "STA Travel",
                        Descricao = "nao sei",
                        Foto = "/img/experiencias/agencias/STA Travel.png",
                        Link = "https://us.jetcost.com/en?&msclkid=e1b5099fa5b612965fdb6fcdfc044c18&utm_source=bing&utm_medium=cpc&utm_campaign=US-EN_B1_F_S_JC_Comp_Global-EXT_mixed&utm_term=sta%20travel%20com&utm_content=Sta%20Travel&gclid=e1b5099fa5b612965fdb6fcdfc044c18&gclsrc=3p.ds",
                        Cor = "#8FB6C8",
                },
                new Agencia() {
                        Id = 4,
                        Nome = "TripAdvisor",
                        Descricao = "nao sei",
                        Foto = "/img/experiencias/agencias/TripAdvisor.png",
                        Link = "https://www.tripadvisor.com.br/",
                        Cor = "#00BF63",
                }
        };
                builder.Entity<Agencia>().HasData(agencias);

                List<Criador> criadores = new(){
                        new Criador() {
                                Id = 1,
                                Nome = "Eduardo Nunes",
                                Sobre = "Programador full stack com ênfase em front-end e criação de layouts",
                                Foto = "/img/Criador/Nunes.png",
                        },
                        new Criador() {
                                Id = 2,
                                Nome = "Ana Clara Mello",
                                Sobre = "Programadora e Dsigner com ênfase em Protótipo",
                                Foto = "/img/Criador/Ana.jpg",

                        },
                        new Criador() {
                                Id = 3,
                                Nome = "Any Gabrieli",
                                Sobre = "Desenvolvedora e Escritora com ênfase em Documentação",
                                Foto = "/img/Criador/Any.png",
                        },
                        new Criador() {
                                Id = 4,
                                Nome = "Eduardo Dametto",
                                Sobre = "Desenvolvedor e Disgner com ênfase em criação de protótipo e Figma",
                                Foto = "/img/Criador/dametto.png",
                        }
                };
                builder.Entity<Criador>().HasData(criadores);


                #region Pais
                List<Pais> paises = new() {
            new Pais() {
                Id = 1,
                Nome = "Argentina",
                Foto = "/img/pais/Argentina.png"
            },
            new Pais() {
                Id = 2,
                Nome = "EUA",
                Foto = "/img/pais/EUA.png"
            },
            new Pais() {
                Id = 3,
                Nome = "França",
                Foto = "/img/pais/França.png"
            },
            new Pais() {
                Id = 4,
                Nome = "Inglaterra",
                Foto = "/img/pais/Inglaterra.png"
            },
            new Pais() {
                Id = 5,
                Nome = "Itália",
                Foto = "/img/pais/Italia.png"
            },
            new Pais() {
                Id = 6,
                Nome = "Portugal",
                Foto = "/img/pais/Portugal.png"
            }
        };
                builder.Entity<Pais>().HasData(paises);
                #endregion

                List<Local> locais = new() {
        #region Argentina
                // 1 a 36   
                #region AG Natureza
                new Local() {
                        Id = 1,
                        Nome = "Parque Nacional Los Glaciales (Provícia de Santa Cruz)",
                        Localizacao ="Parque Nacional da Província de Santa Cruz.",
                        Telefone = "542902491005",
                        HorarioFuncionamento= "Abre no verão de 1º de setembro a 30 de abril das 8h às 18h e no Inverno de 1 de maio a 31 de agosto das 9h às 16h.",
                        Descricao = "O Parque Nacional Los Glaciares localiza-se na região da Patagônia Argentina no sudoeste da Província de Santa Cruz, Argentina, sendo o segundo maior do país. O parque foi instituído pelo governo em 1937, e batizado Los Glaciares pois a área do parque nacional abriga inúmeros glaciares. ",
                        Foto = "/imgpaises/imgArgentina/Natureza/ParqueNacionalLosGlaciales(ProvíciaeSantaCruz).png",
                        PaisId=1,
                        Latitude = -50.33052817623086,
                        Longitude =  -73.23418011349693
                },
                new Local() {
                        Id = 2,
                        Nome = "Parque Nacional Nauhel Huapi (Patagônia)",
                        Localizacao ="Lago Nahuel Huapi- região da Patagônia.",
                        Telefone = "+54 11 5091-7200",
                        HorarioFuncionamento= "Semana inteira/ 09:00 até 19:00",
                        Descricao = "O parque é o mais antigo dos parques nacionais argentinos. Foi criado em 1934, sobre a base da doação de três léguas quadradas (225.000 ha) feita por Francisco Pascasio Moreno em 1903 para sua criação.",
                        Foto = "/imgpaises/imgArgentina/Natureza/Parque-Nacional-nahuel-huapi.png",
                        PaisId=1,
                        Latitude = -40.938009,
                        Longitude = -71.613046
                },
                new Local() {
                        Id = 3,
                        Nome = "Parque Nacional Tierra del Fuego (Ushuaia)",
                        Localizacao ="RN3 kilometro 3067, V9410 Ushuaia, Tierra del Fuego.",
                        Telefone = "+54 2901 57-7931",
                        HorarioFuncionamento= "Semana inteira/ 08:00 até 20:00",
                        Descricao = "O que mais chama a atenção dentro do parque é a topografia montanhosa, além da enorme quantidade de áreas verdes, dos lagos, dos bosques e da paisagem natural como um todo. Ainda que o parque esteja em território argentino, parte dele está em território chileno, então algumas montanhas que se vê dentro do parque pertencem ao Chile. O lugar também é famoso por ser o final da Ruta N3, que faz parte do sistema de rodovias panamericanas.",
                        Foto = "/imgpaises/imgArgentina/Natureza/ParqueNacionalTierradelFuego(Ushuaia).png",
                        PaisId=1,
                        Latitude = -54.83475225751397,
                        Longitude = -68.44648384449509
                },
                new Local() {
                        Id = 4,
                        Nome = "Jardim Zoológico de Buenos Aires (Buenos Aires)",
                        Localizacao ="Av. Sarmiento 2601, C1045 Buenos Aires.",
                        Telefone = "+54 11 5091-7200",
                        HorarioFuncionamento= "Abre de Terça a Domingo das 11:00 até as 18:00 ",
                        Descricao = "Na entrada do Jardim Zoológico é possível comprar comida para os animal. Assim, quando você entrar, poderá alimentar diversas espécies e observar inúmeros bichos que não vemos no dia a dia.",
                        Foto = "/imgpaises/imgArgentina/Natureza/JardimZoológicodeBuenosAires(BuenosAires).png",
                        PaisId=1,
                        Latitude = -34.55930431288427,
                        Longitude = -59.01872631599637
                },
                new Local() {
                        Id = 5,
                        Nome = "Bioparque Temaikén (Buenos Aires)",
                        Localizacao ="RP25, B1625 Belén de Escobar, Provincia de Buenos Aires.",
                        Telefone = "+54 348 443-6980",
                        HorarioFuncionamento= "Abre a semana inteira das 10:00 as 19:00",
                        Descricao = "Não é um zoológico e nem é um jardim botânico, também não é uma fazenda e tampouco um museu de história natural. O Temaikén, distante cerca de 40 minutos de Buenos Aires, é uma mistura de tudo isso e um pouco mais. Um bioparque para viver a natureza de distintas maneiras e, sobretudo, com muita diversão, especialmente para a criançada.",
                        Foto = "/imgpaises/imgArgentina/Natureza/BioparqueTemaikén(BuenosAires).png",
                        PaisId=1,
                        Latitude = -34.3402469529864,
                        Longitude = -58.80869862129423
                },
                new Local() {
                        Id = 6,
                        Nome = "Parque Nacional Iguazú (Missiones- Puerto Iguazú)",
                        Localizacao ="Rota 101 Km 142, N3370 Puerto Iguazú, Misiones.",
                        Telefone = "+54 9 3757 67-4714",
                        HorarioFuncionamento= "Todos os dias das 08:00 as 18:00",
                        Descricao = "O Parque Nacional Iguazú é uma área protegida, criada na Argentina no ano 1934 com o objetivo de conservar as Cataratas do Iguaçu e a biodiversidade que as rodeia. Localizado no norte da província de Misiones, o parque conta com uma superfície aproximada de 67.000 hectares e a sua entrada está a 7 km de Puerto Iguazú.",
                        Foto = "/imgpaises/imgArgentina/Natureza/Parque Nacionalguazú(Missiones-PuertoIguazú).png",
                        PaisId=1,
                        Latitude = -25.660018284382353,
                        Longitude = -54.444980587863554
                },
                #endregion

                #region AG Compras
                new Local() {
                        Id = 7,
                        Nome = "Feira de San Telmo (Buenos Aires)",
                        Localizacao ="Rua Defensa, San Telmo, Buenos Aires.",
                        Telefone = "+54 9 3757 67-4714",
                        HorarioFuncionamento= "Domingo das 10:00 até as 17:00",
                        Descricao = "Há mais de 40 anos, San Telmo, bairro localizado ao sul de Buenos Aires, recebe pessoas da Argentina e do mundo inteiro que visitam o bairro aos domingos para conhecer a famosa Feira de San Telmo. Além dos diversos produtos de antiguidade, a feira também vende artesanato local, produtos com temas da cidade, livros, discos, camisetas, óculos, chapéus, cartões, fotografias, CDs, pôsteres, roupas, calçados e muito mais!",
                        Foto = "/imgpaises/imgArgentina/Compras/FeiradeSanTelmo(Buenos Aires).png",
                        PaisId=1,
                        Latitude = -34.62027522831933,
                        Longitude = -58.37120491914526
                },
                new Local() {
                        Id = 8,
                        Nome = "Galerias Pacífico (Buenos Aires)",
                        Localizacao ="Av. Córdoba 550, C1054 Buenos Aires.",
                        Telefone = "+54 11 5555-5110",
                        HorarioFuncionamento= "Abre todos os dias das 10:00 até as 21:00",
                        Descricao = "Aos falar de compras em Buenos Aires um dos primeiros lugares que surgem na mente são as Galerias Pacífico. O edifício do centro comercial é do fim do século XIX e sua cúpula central foi pintada em 1946. O shopping é tão bonito e bem decorado que recomendamos a visita não apenas a quem deseja fazer compras como a quem procura apenas um lugar para bater perna e quer ver coisas bonitas. O charme da arquitetura das Galerias é ímpar, cheio de murais, colunas e um teto lindíssimo. A arquitetura do shopping é tão imponente que o edifício é considerado monumento histórico nacional.",
                        Foto = "/imgpaises/imgArgentina/Compras/GaleriasPacífico(BuenosAires).png",
                        PaisId=1,
                        Latitude = -34.599132908132724,
                        Longitude = -58.374832153552276
                },
                new Local() {
                        Id = 9,
                        Nome = "Distritos Arcos (Buenos Aires)",
                        Localizacao ="Paraguay 4979, C1425BTC C1425BTA, Buenos Aires.",
                        Telefone = "+54 800-222-2299",
                        HorarioFuncionamento= "Abre todos os dias das 10:00 até as 22:00",
                        Descricao = "Instalado nos antigos edifícios existentes na Propriedade Ferroviária localizada no bairro de Palermo, entre as avenidas Juan B. Justo e Santa Fé, e as ruas Godoy Cruz e Paraguai.As lojas desenvolvem-se para o interior dos espaços cobertos existentes e as áreas comuns são quase inteiramente exteriores. O setor construído é caracterizado pela presença das estruturas de tijolo do viaduto ferroviário que definem o interior urbano e as fachadas exteriores.",
                        Foto = "/imgpaises/imgArgentina/Compras/Distrito ArcosBuenosaires",
                        PaisId=1,
                        Latitude = -34.58041196612808,
                        Longitude = -58.427866749837804
                },
                new Local() {
                        Id = 10,
                        Nome = "Patio Bullrich (Marselha)",
                        Localizacao ="Avenida Del Libertador 750.",
                        Telefone = "+54 800-222-2299",
                        HorarioFuncionamento= "Abre todos os dias das 10:00 até as 22:00",
                        Descricao = "Palácios requintados e prédios residenciais luxuosos se combinam a galerias de arte e butiques exclusivas para fazer de Retiro o lugar perfeito para aqueles que gostam de sofisticação. No entanto, o tráfego contínuo de pedestres nos terminais de trens e de ônibus de Retiro, além dos vários caminhões que chegam e saem do porto, mostram que esse bairro nunca descansa. Em um minuto, você está andando por uma estrada repleta de mansões e vitrines de lojas luxuosas. No minuto seguinte, você se vê rodeado por uma multidão apressada para pegar o trem ou ônibus. É a combinação da constante movimentação de pessoas e o ambiente luxuoso e tranquilo que define Retiro e também Buenos Aires, uma cidade cheia de contrastes.",
                        Foto = "/imgpaises/imgArgentina/Compras/PatioBullrich(Marselha)",
                        PaisId=1,
                        Latitude = -32.955524323926134,
                        Longitude = -68.85890340338014
                },
                new Local() {
                        Id = 11,
                        Nome = "Palmares Open Mall (Godoy Cruz)",
                        Localizacao ="RP82 2650, M5501 Godoy Cruz, Mendoza.",
                        Telefone = "+54 261 348-1200",
                        HorarioFuncionamento= "Abre todos os dias das 10:00 até as 21:00",
                        Descricao = "A 15km do centro de Mendoza você encontrará uma boa maneira de resolver suas compras em um só lugar. No Palmares Open Mall é possível encontrar de vestuário a artigos de artesanato, passando pelos vinhos, claro! Se você não resiste a uma voltinha em um grande centro comercial, essa pode ser uma boa pedida. O shopping é bem ao estilo brasileiro: são 120 lojas que vão de grandes marcas a pequenas boutiques. Prático para uma volta e uma refeição rápida. Destaque para o restaurante Don Mario, que serve uma das mais famosas parrilladas da cidade.",
                        Foto = "/imgpaises/imgArgentina/Compras/PalmaresOpenMall(GodoyCruz).png",
                        PaisId=1,
                        Latitude = -34.588693988159875,
                        Longitude = -58.38404467632539
                },
                new Local() {
                        Id = 12,
                        Nome = "Patio olmos (córdoba)",
                        Localizacao ="Av. Vélez Sarsfield 361.",
                        Telefone = "+54 351 570-4199",
                        HorarioFuncionamento= "Abre todos os dias das 10:00 até as 22:00 ",
                        Descricao = "Patio Olmos é uma galeria comercial de grande importância arquitetônica em Córdoba, Argentina, e a mais importante da cidade.",
                        Foto = "/imgpaises/imgArgentina/Compras/PatioOlmos(Córdoba).png",
                        PaisId=1,
                        Latitude = -31.41958968115592,
                        Longitude = -64.18824068140034
                },
                #endregion    

                #region AG Vida Noturna
                new Local() {
                        Id = 13,
                        Nome = "Niceto Club (Buenos Aires)",
                        Localizacao ="Calle Cnel Niceto Vega 5510.",
                        Telefone = "+54 351 570-4199",
                        HorarioFuncionamento= "Abre todos os dias 24 horas por dia",
                        Descricao = "Mais conhecido como o maior bairro de Buenos Aires, Palermo é dividido em partes diferentes, cada uma com uma identidade exclusiva. Palermo Chico é a área mais sofisticada. Caracterizada pelas magníficas mansões, avenidas majestosas, prédios residenciais e por abrigar o Museu de Arte Latino-Americana de Buenos Aires (MALBA), essa região é um dos lugares favoritos dos moradores. O maior parque da cidade, Bosques de Palermo, é o ponto de interesse mais famoso de Palermo. Ele também é um destino popular entre aqueles que querem fazer caminhadas, piqueniques, andar de patins e de bicicleta. Em Palermo Soho, o cenário se torna muito mais moderno. Nos finais de semana, compradores lotam essa área que é famosa pelos cafés descolados e lojas de design exclusivo. Já Palermo Hollywood, conhecida por contar com um grande número de restaurantes, bares e boates, é o lugar preferido dos viajantes que querem se divertir à noite e comemorar ocasiões especiais.",
                        Foto = "/imgpaises/imgArgentina/VidaNoturna/NicetoClub(BuenosAires).png",
                        PaisId=1,
                        Latitude = -34.58703506886908,
                        Longitude = -58.43886607446898
                },
                new Local() {
                        Id = 14,
                        Nome = "Senor Tango (Buenos Aires)",
                        Localizacao ="Vieytes 1655, C1276 Cdad.",
                        Telefone = "+54 11 4303-0231",
                        HorarioFuncionamento= "Abre todos os dias das 20:00 até as 00:00",
                        Descricao = "Considerada uma das melhores casas de tango de Buenos Aires, o Señor Tango oferece um espetáculo inesquecível e muito emocionante. O show é envolvente do início ao fim, apresentando belas coreografias – algumas com certo toque acrobático – que encantam a todo o tipo de público. A apresentação ainda conta com a participação de ótimos cantores e músicos que, em alguns momentos do espetáculo, interagem com a plateia.",
                        Foto = "/imgpaises/imgArgentina/VidaNoturna/SenorTango(BuenosAires).png",
                        PaisId=1,
                         Latitude = -34.56926698554936,
                        Longitude = -58.42052953214304
                },
                new Local() {
                        Id = 15,
                        Nome = "Icebar Iguazu (Puerto Iguazú)",
                        Localizacao ="Ruta Nacional 12 KM 5",
                        Telefone = "+54 11 4778-1500 ",
                        HorarioFuncionamento= "Abre todos os dias das 14:00 até a 00:00",
                        Descricao = "No Ice Bar Puerto Iguazú tudo é feito de gelo: as paredes, os móveis, a decoração e, inclusive, os copos. E, para manter tudo congelado, a temperatura do bar é de -10ºC. Uma grande diferença para o clima da cidade, que pode passar dos 30° no verão.",
                        Foto = "/imgpaises/imgArgentina/VidaNoturna/IcebarIguazu(PuertoIguazú).png",
                        PaisId=1,
                         Latitude = -34.65251488742655,
                        Longitude = -58.37593927446579
                },
                new Local() {
                        Id = 16,
                        Nome = "Crobar (Buenos Aires)",
                        Localizacao ="Av. Coronel Marcelino E. Freyre",
                        Telefone = "+54 11 4303-0231",
                        HorarioFuncionamento= "Abre de sexta, sábado e domingo da 00:00 até as 07:00",
                        Descricao = "Mais conhecido como o maior bairro de Buenos Aires, Palermo é dividido em partes diferentes, cada uma com uma identidade exclusiva. Palermo Chico é a área mais sofisticada. Caracterizada pelas magníficas mansões, avenidas majestosas, prédios residenciais e por abrigar o Museu de Arte Latino-Americana de Buenos Aires (MALBA), essa região é um dos lugares favoritos dos moradores. O maior parque da cidade, Bosques de Palermo, é o ponto de interesse mais famoso de Palermo. Ele também é um destino popular entre aqueles que querem fazer caminhadas, piqueniques, andar de patins e de bicicleta. Em Palermo Soho, o cenário se torna muito mais moderno",
                        Foto = "/imgpaises/imgArgentina/VidaNoturna/Crobar(BuenosAires).png",
                        PaisId=1,
                        Latitude = -25.619359092794305,
                        Longitude = -54.55500692088276
                },
                new Local() {
                        Id = 17,
                        Nome = "Cafe de los Angelitos  (Buenos Aires)",
                        Localizacao ="Rivadavia Ave 2100, corner of Rincon street Balvanera.",
                        Telefone = "+54 11 4952-2320",
                        HorarioFuncionamento= "Abre todos os dias das 09:00 até a 11:00",
                        Descricao = "O Café de los Angelitos é um recinto imponente com mais de cem anos de história, por onde desfilaram grandes personalidades do mundo político e artístico de Buenos Aires. Hoje em dia, é palco de um dos mais refinados e elegantes shows de tango da cidade, diversas vezes aclamado pela crítica local.",
                        Foto = "/imgpaises/imgArgentina/VidaNoturna/CafedelosAngelitos(BuenosAires).png",
                        PaisId=1,
                        Latitude = -34.60946892791383,
                        Longitude = -58.396186547487716
                },
                new Local() {
                        Id = 18,
                        Nome = "Vinology (Buenos Aires)",
                        Localizacao ="República de Eslovenia 1959.",
                        Telefone = "+54 9 11 3100-2433",
                        HorarioFuncionamento= "Abre terça, quarta, quinta, sexta e sábado das 14:00 até as 22:00",
                        Descricao = "Vinology é um lugar incrível para se conhecer os bons vinhos da Argentina. É uma vinoteca diferenciada, que tem etiquetas de bodegas especialmente boas, funciona como bar de vinhos com comidinhas deliciosas.",
                        Foto = "/imgpaises/imgArgentina/VidaNoturna/Vinology(BuenosAires).png",
                        PaisId=1,
                        Latitude = -34.570552378227354,
                        Longitude = -58.434845818652846
                },
                #endregion

                #region AG Espiritualidade
                new Local() {
                        Id = 19,
                        Nome = "Catedral Metropolitana de Buenos Aires (Buenos Aires)",
                        Localizacao ="San Martín 27, C1004",
                        Telefone = "+54 11 4303-0231",
                        HorarioFuncionamento= "De segunda a sexta das 7:30 até as 18:45 e de final de semana das 9:00 até as 18:45.",
                        Descricao = "A Catedral Metropolitano de Buenos Aires é a principal igreja católica em Buenos Aires, capital da Argentina. Localiza-se no centro da cidade, diante da Praça de Maio, na esquina das ruas San Martín e Rivadavia, no bairro de San Nicolás. É a igreja-mãe da Arquidiocese de Buenos Aires",
                        Foto = "/imgpaises/imgArgentina/Fe/CatedralMetropolitanadeBuenosAires(BuenosAires).png",
                        PaisId=1,
                        Latitude = -34.6073662714273,
                        Longitude = -58.37330031865107
                },
                new Local() {
                        Id = 20,
                        Nome = "Basílica de Nuestra Señora de Luján (Luján)  ",
                        Localizacao ="San Martín 51.",
                        Telefone = "+54 2323 42-1070.",
                        HorarioFuncionamento= "Todos os dias das 9:00 até as 18:00",
                        Descricao = "A Basílica Menor de Nossa Senhora de Luján é uma igreja católica romana em Luján, Buenos Aires, Argentina. Construída em estilo neogótico, é dedicada a Nossa Senhora de Luján, padroeira da Argentina. Muitas pessoas confundem esta igreja com uma catedral.",
                        Foto = "/imgpaises/imgArgentina/Fe/Basílica de NuestraSeñoradeLuján(Luján).png",
                        PaisId=1,
                        Latitude = -34.569093609091354,
                        Longitude = -58.44020886390422
                },
                new Local() {
                        Id = 21,
                        Nome = "Igreja de San Francisco (Salta)",
                        Localizacao ="Córdoba 15",
                        Telefone = "+54 387 512-4311",
                        HorarioFuncionamento= "Todos os dias das 8:30 até as 20:30, no Domingo das 8:30 até as 12:00 e das 18:00 até as 21:00",
                        Descricao = "Esta magnífica Basílica Menor, construída em terreno doado por Hernando de Lerma, em 1582, com destaque para as cores poderosas terracota, ouro e marfim que cobrem. Ele pertence à ordem franciscana e foi reconstruído várias vezes após vários incêndios.",
                        Foto = "/imgpaises/imgArgentina/Fe/IgrejadeSanFrancisco(Salta).png",
                        PaisId=1,
                        Latitude = -24.790006713060023,
                        Longitude = -65.40821649021966
                },
                new Local() {
                        Id = 22,
                        Nome = "Catedral de Córdoba (Córdoba)",
                        Localizacao ="C. Cardenal Herrero, 1, Centro. ",
                        Telefone = "+34 957 47 0512. ",
                        HorarioFuncionamento= "De segunda até sábado das 8:30 até as 9:30",
                        Descricao = "A Mesquita-Catedral de Córdova oficialmente conhecida pelo seu nome eclesiástico, a Catedral de Nossa Senhora da Assunção em espanhol: Catedral de Nuestra Señora de la Asunción é a catedral da Diocese Católica Romana de Córdoba dedicada à Assunção de Maria e localizado na região espanhola da Andaluzia.",
                        Foto = "/imgpaises/imgArgentina/Fe/CatedraleCórdoba(Córdoba).png",
                        PaisId=1,
                        Latitude = -28.470207963157378,
                        Longitude = -65.35529771321596
                },
                new Local() {
                        Id = 23,
                        Nome = "Basílica del Santísimo Sacramento (Buenos Aires)",
                        Localizacao ="San Martín 1035.",
                        Telefone = "+54 11 4311-0391.",
                        HorarioFuncionamento= "Quarta-feira, 11:00–13:00, 18:00–20:00, quinta-feira, 11:00–13:00, 18:00–20:00, sexta-feira, 11:00–13:00, 18:00–20:00, sábado, 18:30–20:00, domingo, 09:00–12:30, 17:30–20:30, segunda-feira, 11:00–13:00, 18:00–20:00, terça-feira, 11:00–13:00, 18:00–20:00.",
                        Descricao = "A Basílica do Santísimo Sacramento é uma das igrejas mais bonitas de Buenos Aires. O templo luxuosamente decorado apresenta uma grande custódia de ouro e prata, vitrais importantes e ornamentos de mármore, granito azul, bronze e mosaico veneziano.",
                        Foto = "/imgpaises/imgArgentina/Fe/BasílicadelSantísimoSacramento(Buenos Aires).png",
                        PaisId=1,
                        Latitude = -34.59546334232072,
                        Longitude = -58.37423653771114
                },
                new Local() {
                        Id = 24,
                        Nome = "Catedral de Nuestra Señora del Nahuel Huapi (Bariloche)",
                        Localizacao ="Vice Almte. O'Connor 500.",
                        Telefone = "+54 294 443-4084 ",
                        HorarioFuncionamento= "De segunda a sexta das 9:00 até as 12:00 e das 17:00 até 21:00.",
                        Descricao = "A Catedral de San Carlos de Bariloche é o principal templo católico da cidade de San Carlos de Bariloche, na Argentina. Encontra-se na interseção das ruas Almirante Ou’Connor e Beschtedt, rodeada por duas praças com formosos jardins. É a sé episcopal da Diocese de Bariloche, sufragânea da Arquidiocese de Bahía Blanca.",
                        Foto = "/imgpaises/imgArgentina/Fe/CatedraldeNuestraSeñoradelNahuelHuapi(Bariloche).png",
                        PaisId=1,
                        Latitude = -41.13291181780236,
                        Longitude = -71.30234644530549
                },
                #endregion

                #region AG Restaurantes
                new Local() {
                        Id = 25,
                        Nome = "Don Julio (Buenos Aires)",
                        Localizacao ="Calle Guatemala 4699 Palermo Viejo",
                        Telefone = "+54 11 4832-6058",
                        HorarioFuncionamento= "Abre todos os dias das 11:30 até as 16:00 e depois das 19:00 até as 1:00",
                        Descricao = "Reservar uma mesa no restaurante Don Julio já virou uma atração turística imperdível em Buenos Aires. Os reconhecimentos ajudam: é atualmente o restaurante argentino mais bem colocado entre os 50 melhores do mundo e foi eleito neste ano como a melhor casa de carnes do mundo. As filas que se formam na porta todos os dias são outro medidor do sucesso.",
                        Foto = "/imgpaises/imgArgentina/Restaurantes/DonJulio(BuenosAires).png",
                        PaisId=1,
                        Latitude = -34.58613638501554,
                        Longitude = -58.4242476186521
                },
                new Local() {
                        Id = 26,
                        Nome = "La Cabrera (Buenos Aires)",
                        Localizacao ="Jose Antonio Cabrera 5099 Palermo.",
                        Telefone = "+54 11 5586-1435.",
                        HorarioFuncionamento= "Domingo das 12:30 até as 16:00, Segunda das 11:30 até as 16:00 e das 6:30 até as 12:30, de terça, quarta e quinta das 6:30 até as 12:30 e de sexta e sábado das 12:30 até as 16:00 e das 6:30 até as 1:00.",
                        Descricao = "O La Cabrebra é especialista em cortes de carnes, acompanhamentos saborosos e, claro, com muita fartura. É mais um restaurante que figura entre os melhores de Buenos Aires, pelo atendimento, pelo ambiente clássico e pela qualidade das carnes. Nove entre dez brasileiros que visitam a capital, fazem questão de passar no La Cabrera e aproveitar o almoço, happy hour ou jantar.",
                        Foto = "/imgpaises/imgArgentina/Restaurantes/LaCabrera(BuenosAires).png",
                        PaisId=1,
                        Latitude = -34.588799061101504,
                        Longitude = -58.43325444563225
                },
                new Local() {
                        Id = 27,
                        Nome = "1884 Restaurante Francis Mallmann (Mendonza)",
                        Localizacao ="Calle Gral Manuel Belgrano 1188",
                        Telefone = "+54 261 424-2698",
                        HorarioFuncionamento= "De terça até Domingo das 19:00 até as 21:30",
                        Descricao = "A poucos minutos do centro - na Bodega Escorihuela -, o elegante 1884, chefiado por Francis Mallmann, carrega a fama de ser o melhor restaurante da cidade. Se não for o melhor, certamente está na lista dos imperdíveis.O ambiente é refinado e clássico, com salões externos e internos. A culinária, tipicamente portenha, vai das empanadas aos melhores cortes de carne.",
                        Foto = "/imgpaises/imgArgentina/Restaurantes/1884RestauranterancisMallmann(Mendonza).png",
                        PaisId=1,
                        Latitude = -32.91212429424235,
                        Longitude = -68.84302357268902
                },
                new Local() {
                        Id = 28,
                        Nome = "Oviedo (Rosário)",
                        Localizacao ="C. Jovellanos, 2.",
                        Telefone = "+34 984 03 40 14",
                        HorarioFuncionamento= "De terça até Sábado das 10:30 até as 20:00.",
                        Descricao = "O Oviedo é o restaurante mais tradicional de Buenos Aires quando o assunto é peixe! Os pescados servidos no restaurante estão sempre super frescos, pois o restaurante recebe mercadoria duas vezes ao dia, além disso toda matéria prima servida é de altíssima qualidade e fresca, o que garante um prato muito mais saboroso! O que achamos incrível é que tudo que sai da cozinha parece verdadeira obra de arte, isto porque o chef Martin Rebaudino estudou belas artes para deixar seus pratos mais bonitos e também chegou a trabalhar no El Bulli.",
                        Foto = "/imgpaises/imgArgentina/Restaurantes/Oviedo(Rosário).png",
                        PaisId=1,
                        Latitude = -32.95622585219165,
                        Longitude = -60.64688716233088
                },
                new Local() {
                        Id = 29,
                        Nome = "Siete Cocinas (Salta)",
                        Localizacao ="Av. Bartolomé Mitre 794, na cidade de Mendoza, Argentina.",
                        Telefone = "+34 984 03 40 14.",
                        HorarioFuncionamento= "De Segunda até Sábado das 20:00 até as 00:00.",
                        Descricao = "Entre pescados, massas e assados, bem elaborados em um ambiente simples e elegante, você percorrerá um longo e saboroso caminho pelo melhor da comida argentina.",
                        Foto = "/imgpaises/imgArgentina/Restaurantes/SieteCocinas(Salta)melhorado.png",
                        PaisId=1,
                        Latitude = -3.487697620654168,
                        Longitude = -76.51273403305537
                },
                new Local() {
                        Id = 30,
                        Nome = "Fogón Asado (Buenos Aires)",
                        Localizacao ="Uriarte 1423.",
                        Telefone = "+54 11 2142-2936.",
                        HorarioFuncionamento= "Todos os dias das 7:45 até as 10:30, apenas de segunda das 7:45 até as 10:00.",
                        Descricao = "Estabelecimento é um omakase de carnes com reservas disputadas. Com uma recepção acolhedora no bairro de Palermo Viejo, em Buenos Aires, o Fogón Asado é um omakase de carnes que oferece uma experiência de 10 passos (US$ 80). Para ir ao Fogón é preciso estar com fome, pois os 10 tempos são substanciosos.",
                        Foto = "/imgpaises/imgArgentina/Restaurantes/FogónAsado(BuenosAires).png",
                        PaisId=1,
                        Latitude = -34.58829224205065,
                        Longitude = -58.43371108123645
                },
                #endregion

                #region AG Cultura
                new Local() {
                        Id = 31,
                        Nome = "Museu Nacional de Belas Artes (Buenos Aires)",
                        Localizacao ="Av. del Libertador 1473",
                        Telefone = "+54 11 5288-9900",
                        HorarioFuncionamento= "De terça até domingo das 11:00 até as 20:00",
                        Descricao = "Museo Nacional de Bellas Artes. O Museu exibe mais de 40 pinturas a óleo e aquarelas do artista, 200 anos após seu nascimento. A exposição reúne cerca de 90 pinturas, desenhos e documentos dos primeiros anos da carreira de Jorge Gumier Maier (1953-2021).",
                        Foto = "/imgpaises/imgArgentina/Cultura/MuseuNacionaldeBelasArtes(BuenosAires).png",
                        PaisId=1,
                        Latitude = -34.5838215458417,
                        Longitude = -58.3930473186523
                },
                new Local() {
                        Id = 32,
                        Nome = "Museu de Arte Latino-Americana de Buenos Aires (MALBA) (Buenos Aires)",
                        Localizacao ="Av. Pres. Figueroa Alcorta 3415.",
                        Telefone = "+54 11 4808-6500",
                        HorarioFuncionamento= "Abre todos os dias menos de Terça das 11:00 até as 20:00",
                        Descricao = "Conheça o Museu de Arte Latino Americana (MALBA) de Buenos Aires. Localizado no famoso bairro Palermo, o MALBA é um dos melhores museus em Buenos Aires. Ele tem a intenção de promover a arte da América Latina a partir do século 20, e por isso lá você vai encontrar desdes artistas famosos e renomados, até aqueles mais novos que ainda estão buscando seu espaço no meio artístico. Confira abaixo mais informações sobre o Museu de Arte Latino Americana. ",
                        Foto = "/imgpaises/imgArgentina/Cultura/MuseudeArteLatino-AmericanadeBuenosires(MALBA)(Buenos Aires).png",
                        PaisId=1,
                         Latitude = -34.576721381507,
                        Longitude = -58.403494562835725
                },
                new Local() {
                        Id = 33,
                        Nome = "Museu de Arte Pré-Colombiana e Arte Popular (Córdoba)",
                        Localizacao ="Pl. del Potro, 1, Centro.",
                        Telefone = "+34 957 01 58 58.",
                        HorarioFuncionamento= "De terça até Domingo das 9:00 até as 21:00 e excessão de do Domingo das 9:00 até as 15:00.",
                        Descricao = "O Museu de Belas Artes de Córdoba é um museu de arte estatal localizado na cidade espanhola de Córdoba. ",
                        Foto = "/imgpaises/imgArgentina/Cultura/MuseudeArtePré-ColombianaeArtePopular(Córdoba).png",
                        PaisId=1,
                         Latitude = -40.2823238777987,
                        Longitude = -5.179755649099501
                },
                new Local() {
                        Id = 34,
                        Nome = "Museu de La Plata (La Plata)",
                        Localizacao ="Paseo del Bosque s/n.",
                        Telefone = "+54 221 425-7744.",
                        HorarioFuncionamento= "De Quarta até Domingo das 10:00 até as 18:00.",
                        Descricao = "O museu apresenta em torno de 3.000.000 de objetos em sua coleção, e só uma pequena parte dos mesmos se encontram em exibição. Em grande parte, o prestígio do museu descansa em sua coleção de grandes mamíferos fósseis dos pampas sul-americanos das eras Terciária e Quaternária. Também se destacam as coleções de trilobites do período Cambriano e de graptólitos do período Silúrico da Argentina. O museu conta também com salas de Zoologia, Entomologia, e Botânica.",
                        Foto = "/imgpaises/imgArgentina/Cultura/MuseudeLaPlata(LaPlata).png",
                        PaisId=1,
                         Latitude = -34.579509537505956,
                        Longitude = -58.405005476325684
                },
                new Local() {
                        Id = 35,
                        Nome = "Museu de Arte Contemporânea de Bahía Blanca (Bahía Blanca)",
                        Localizacao ="Sarmiento, 450",
                        Telefone = "+54 221 425-7744",
                        HorarioFuncionamento= "De Segunda até Quinta das 9:00 até as 13:00, sexta das 13:00 até as 17:00 e Domingo das 16:00 até as 20:00.",
                        Descricao = "O Ocupam um importante edifício construído na década de 1920. O Museo de Bellas Artes dedica-se à exposição de uma importante coleção de pintura argentina do final do século XIX ao XX. Já o MAC conta com 6 salas de exposições e possui um grande terraço e jardins que circundam o edifício, onde regularmente se programam concertos, espetáculos, peças de teatro, entre outros.",
                        Foto = "/imgpaises/imgArgentina/Cultura/MuseueArteContemporâneaeBahíaBlanca(Bahía Blanca).png",
                        PaisId=1,
                         Latitude = -38.712929512680304,
                        Longitude = -62.26223254543124
                },
                new Local() {
                        Id = 36,
                        Nome = "Museu de História Nacional (Rosário)",
                        Localizacao ="Av. Dr. Eduardo María Gallo s/n.",
                        Telefone = "+54 221 425-7744",
                        Descricao = "O museu, que primeiro foi chamado Museo Histórico de la Capital, foi criado pelo Intendente Francisco Seeber em 24 de maio de 1889. Adolfo Carranza foi designado diretor do museu que só seria inalgurado no dia 15 de fevereiro de 1891, em um terreno pertencente ao governo nacional. Parte da coleção provinha de descendentes dos homens importantes da Revolución de Maio e da Guerra de Independência, com os quais Carranza tinha se comunicado para pedir-lhes que doassem. A outra parte provinha do Museo Público, instituição formada em 1822 por Bernardino Rivadavia que por disposições oficiais viu-se obrigada a doar os objetos.",
                        HorarioFuncionamento= "Segunda a Sexta, das 9:00 até 16:00",
                        Foto = "/imgpaises/imgArgentina/Cultura/Museu de História Nacional (Rosário).png",
                        PaisId=1,
                        Latitude = -34.62680174739552,
                        Longitude = -58.37054628795715
                },
                #endregion
        #endregion

        #region Estados Unidos
                // 37 a 72
                #region EUA Natureza
                new Local () {
                        Id = 37,
                        Nome = "Parque Evergales (Flórida)",
                        Localizacao = "Flórida",
                        Telefone = "+1 305-242-7700",
                        HorarioFuncionamento = "Todos os dias das 9 =00 até 17 =00",
                        Descricao = "O Parque Nacional de Everglades é um parque nacional norte-americano localizado no estado da Flórida, e que serve de proteção a 20% da área original de Everglades. Nos Estados Unidos, é a maior zona tropical, e a maior de qualquer tipo a este do rio Mississipi, e recebe uma média de um milhão de visitantes por ano.",
                        Foto = "/imgpaises/imgEUA/Natureza/Parque Evergales (Flórida);.png",
                        PaisId = 2,
                        Latitude = -25.306024577107607,
                        Longitude = -80.89282923617047
                },
                new Local () {
                        Id = 38,
                        Nome = "Zoológico do Bronx (NY)",
                        Localizacao = "2300 Southern Blvd",
                        Telefone = "+1 718-220-5100",
                        HorarioFuncionamento = "Todos os dias das 10 =00 até 16 =30",
                        Descricao = "O Zoológico do Bronx é um famoso zoológico localizado no Bronx Park, no Bronx, em Nova Iorque. É o maior zoológico urbano dos Estados Unidos, compreende 107 hectares de parques e habitações naturais às margens do rio Bronx. O Zoológico do Bronx está situado ao sul do Jardim Botânico de Nova Iorque.",
                        Foto = "/imgpaises/imgEUA/Natureza/Zoológico do Bronx (NY);.png",
                        PaisId = 2,
                        Latitude = -40.85038496567785,
                        Longitude = -73.87685044602321
                },
                new Local () {
                        Id = 39,
                        Nome = "Yellowstone (Wyoming)",
                        Localizacao = "Wyoming 82190",
                        Telefone = "+1 718-220-5100",
                        HorarioFuncionamento = "Todos os dias 24h",
                        Descricao = "O Parque Nacional de Yellowstone é um parque nacional norte-americano localizado nos estados de Wyoming, Montana e Idaho. É o mais antigo parque nacional no mundo, e um marco na história das áreas protegidas. Foi inaugurado a 1 de março de 1872 e cobre uma área de 8 980 km², estando a maior parte dele no condado de Park, no noroeste do Wyoming. O parque é famoso por, entre outras atrações, seus gêiseres, suas fontes termais e por sua variedade de vida selvagem, na qual incluem-se ursos mansos, lobos, bisontes, alces, e outros animais. É o centro do grande ecossistema de Yellowstone, que é um dos maiores ecossistemas de clima temperado ainda restantes no planeta. O gêiser mais famoso do mundo, denominado Old Faithful, encontra-se neste parque. A cidade mais próxima do parque Yellowstone é Billings, Montana.",
                        Foto = "/imgpaises/imgEUA/Natureza/Yellowstone (Wyoming);.png",
                        PaisId = 2,
                        Latitude = -44.654356927387575,
                        Longitude = -110.56717507431897
                },
                new Local () {
                        Id = 40,
                        Nome = "Zoológico de San Diego (California)",
                        Localizacao = "2920 Zoo Dr",
                        Telefone = "+1 619-231-1515",
                        HorarioFuncionamento = "De Segunda até Domingo das 9 =00 até as 17 =00",
                        Descricao = "O Zoológico de San Diego é um zoológico em Balboa Park, San Diego, Califórnia, que abriga mais de 3 700 animais de mais de 650 espécies e subespécies.Sua organização mãe, a San Diego Zoo Global, é a maior associação zoológica do mundo, com mais de 250 mil famílias membros e 130 mil crianças afiliadas, representando mais de meio milhão de pessoas. O Zoológico de San Diego foi pioneiro no conceito de exibições ao ar livre sem jaulas que recriam habitats naturais dos animais. Ele é um dos poucos zoológicos no mundo que abriga o panda-gigante. Em 2013, o zoológico incluiu uma nova Koalafornia Adventure, oferecendo uma experiência australiana.",
                        Foto = "/imgpaises/imgEUA/Natureza/Zoológico de San Diego (California).png",
                        PaisId = 2,
                        Latitude = -32.73666104361093,
                        Longitude = -117.15086363584145
                },

                new Local () {
                        Id = 41,
                        Nome = "Grand Canyon (Arizona)",
                        Localizacao = "Arizona 86023",
                        Telefone = "(928) 638-7888",
                        HorarioFuncionamento = "De Segunda até Domingo das 7 =00 até as 19 =00",
                        Descricao = "O Parque Nacional do Grand Canyon, no Arizona, engloba grande parte do imenso Grand Canyon, com as formações de rocha vermelha em camadas, que revelam milhões de anos de história geológica. Os miradouros incluem Mather Point, a estação de observação de Yavapai e o Lookout Studio e a Torre de Vigia Desert View, da arquiteta Mary Colter. Lipan Point permite vistas amplas do desfiladeiro e do rio Colorado e é popular, sobretudo ao nascer e pôr-do-sol.",
                        Foto = "/imgpaises/imgEUA/Natureza/Grand Canyon (Arizona);.png",
                        PaisId = 2,
                        Latitude = -36.10190066562183,
                        Longitude = -112.11293869457225
                },

                new Local () {
                        Id = 42,
                        Nome = "Trilha Hoh Rain Forest (Washington)",
                        Localizacao = "821 Main Ave, Forks, WA 98331",
                        Telefone = "(360) 373-4400",
                        HorarioFuncionamento = "Todos os dias 24h",
                        Descricao = "A fresca e nevoenta floresta Hoh abriga uma incrível variedade de árvores. O bordo e o amieiro são comuns, mas são as altas coníferas que dominam a paisagem. Entre as mais altas estão os pinheiros e os abetos, inclusive o que é conhecido como abeto de Douglas. Essas árvores gigantescas atingem até 90 metros de altura, e seus troncos chegam a medir 6 metros de diâmetro. Caminhe por uma das trilhas bem sinalizadas que há sob esses gigantes de centenas de anos de idade.",
                        Foto = "/imgpaises/imgEUA/Natureza/Trilha Hoh Rain Forest (Washington).png",
                        PaisId = 2,
                        Latitude = -47.86076318846287,
                        Longitude = -123.9347339963421
                },
        #endregion

        #region EUA Compras
                new Local () {
                        Id = 43,
                        Nome = "The Grove (Los Angeles)",
                        Localizacao = "189 The Grove Dr, Los Angeles",
                        Telefone = "+1 323-900-8080",
                        HorarioFuncionamento = "Sábado e sexta, 10 =00–22 =00/ domingo, 11 =00–20 =00/ segunda-feira e terça, 10 =00–21 =00/ quarta-feira e quinta, 10 =00–21 =00",
                        Descricao = "O Grove, ou Bosque, é encantador. Muito além de um simples shopping, o espaço é ótimo para passear ao ar livre. A praça central, coberta de grama, fontes, coretos, pontes e árvores, é um convite a relaxar em meio à confusão de Los Angeles. ",
                        Foto = "/imgpaises/imgEUA/Compras/The Grove (Los Angeles).png",
                        PaisId = 2,
                        Latitude = -34.072249556862126,
                        Longitude = -118.35749003148823
                },

                new Local () {
                        Id = 44,
                        Nome = "Chelsea Market (Nova York)",
                        Localizacao = "75 9th Ave, New York",
                        Telefone = "+1 212-652-2111",
                        HorarioFuncionamento = "Todos os dias das 08 =00 até as 21 =00",
                        Descricao = "Entre as diversas atrações na região do Chelsea, o charmoso mercado gastronômico Chelsea Market é o que mais chama atenção dos turistas. Inaugurado em 1997, antes funcionava a antiga fábrica da Nabisco, onde a bolacha Oreo foi inventada e produzida. No térreo do prédio você vai encontrar 59 lojas e restaurantes, nos andares superiores do edifício estão as sedes de grandes empresas como Google, YouTube, EMI Music, MLB.com entre outras grandes empresas.",
                        Foto = "/imgpaises/imgEUA/Compras/Chelsea Market (Nova York).png",
                        PaisId = 2,
                        Latitude = -40.742772546354566,
                        Longitude = -74.00613581718825
                },

                new Local () {
                        Id = 45,
                        Nome = "Disney Springs (orlando)",
                        Localizacao = "1486 Buena Vista Dr, Lake Buena Vista",
                        Telefone = "+1 407-939-5277",
                        HorarioFuncionamento = "Todos os dias das 10 =00 até as 11 =00",
                        Descricao = "Disney Springs, antigamente chamada de Downtown Disney é um centro de compras, restaurantes, teatro e outros tipos de entretenimento pertencente à Walt Disney Company e localizado no complexo Walt Disney World. Situa-se na cidade de Bay Lake, Flórida, próxima de Orlando.",
                        Foto = "/imgpaises/imgEUA/Compras/Disney Springs (orlando).png",
                        PaisId = 2,
                        Latitude = -28.371019076866045,
                        Longitude = -81.51933837544016
                },

                new Local () {
                        Id = 46,
                        Nome = "Walmart (Albany, NY)",
                        Localizacao = "141 Washington Ave Ext, Albany",
                        Telefone = " +1 518-869-4694",
                        HorarioFuncionamento = "Todos os dias das 06 =00 até as 23 =00",
                        Descricao = "Esteja você procurando móveis novos para renovar sua casa ou uma bicicleta novinha em folha para levá-lo do ponto A ao ponto B, você pode fazer todas as suas compras em uma viagem fácil ao Walmart. De brinquedos e videogames a roupas da moda e sapatos combinando para toda a família, sua Albany Walmart Superstore tem de tudo.",
                        Foto = "/imgpaises/imgEUA/Compras/Walmart (Albany, NY).png",
                        PaisId = 2,
                        Latitude = -42.69543550778833,
                        Longitude = -73.84711562526202
                },

                new Local () {
                        Id = 47,
                        Nome = "Aventura Mall (Miami)",
                        Localizacao = "19501 Biscayne Blvd, Aventura",
                        Telefone = "+1 305-935-1110",
                        HorarioFuncionamento = "Todos os dias das 10 =00 até as 21 =30",
                        Descricao = "Aventura Mall é um shopping localizado em Aventura, Flórida. É o terceiro maior shopping dos Estados Unidos em metros quadrados totais de área de varejo e o maior shopping da Flórida. O shopping oferece JCPenney, Macy's, Nordstrom e Bloomingdale's, além de cinemas AMC com 24 telas.",
                        Foto = "/imgpaises/imgEUA/Compras/Aventura Mall (Mimi).png",
                        PaisId = 2,
                        Latitude = -25.957219503652013,
                        Longitude = -80.14270392930834
                },

                new Local () {
                        Id = 48,
                        Nome = "Neiman Marcous(Dallas)",
                        Localizacao = "8687 N Central Expy, Dallas",
                        Telefone = "+1 214-363-8311",
                        HorarioFuncionamento = "De segunda até sábado das 10 =00 até as 20 =00 e de domingo das 12 =00 até as 18 =00",
                        Descricao = "Criada à imagem e semelhança da Macy's, uma das mais antigas e importantes rede de lojas de departamento dos EUA, a Neiman Marcus foi fundada em 1907, no Texas, e rapidamente se tornou uma das redes mais badaladas do mercado americano.",
                        Foto = "/imgpaises/imgEUA/Compras/Neiman Marous(Dallas).png",
                        PaisId = 2,
                        Latitude = -32.78122160895094,
                        Longitude = -96.79715947107249
                },
        #endregion

        #region EUA Vida Noturna
                new Local () {
                        Id = 49,
                        Nome = "Marquee Nightclub (Nevada)",
                        Localizacao = "Located Inside the Cosmopolitan, 3708 S Las Vegas Blvd, Las Vegas, NV 89109",
                        Telefone = "+1 702-333-9000",
                        HorarioFuncionamento = "Abre de Domingo, quarta, sexta e sábado das 22 =00 até as 04 =00",
                        Descricao = "Ótima balada, casa muito bonita e bem frequentada. Local animado e as atrações agitam bastante o público. Uma das melhores boates que já fui em NY. Noite super animada, pessoas bonitas e simpáticas de todos os cantos do mundo.",
                        Foto = "/imgpaises/imgEUA/VidaNoturna/Marquee Nightclub (Nevada).png",
                        PaisId = 2,
                        Latitude = -36.11012002671051,
                        Longitude = -115.174144496593
                },

                new Local () {
                        Id = 50,
                        Nome = "The Varnish (Los Angeles)",
                        Localizacao = "118 E 6th St, Los Angeles, CA 90014 ",
                        Telefone = "+1 213-265-7089",
                        HorarioFuncionamento = "Abre todos os dias das 19 =00 até as 02 =00",
                        Descricao = "O Varnish foi inaugurado em 2009 e recebeu elogios, incluindo o Melhor Bar Americano do Spirited Awards e um lugar na lista dos 50 Melhores Bares do Mundo. Mesmo com sua pequena lista de coquetéis práticos de estilo clássico, o bar conseguiu permanecer no radar de todos os bebedores de Los Angeles, durante toda a moda do farm-to-glass, o movimento de mixologia molecular e até mesmo o atual frenesi do brilho do Instagram. O Varnish foi inaugurado em 2009 e recebeu elogios, incluindo o Melhor Bar Americano do Spirited Awards e um lugar na lista dos 50 Melhores Bares do Mundo. Mesmo com sua pequena lista de coquetéis práticos de estilo clássico, o bar conseguiu permanecer no radar de todos os bebedores de Los Angeles, durante toda a moda do farm-to-glass, o movimento de mixologia molecular e até mesmo o atual frenesi do brilho do Instagram. ",
                        Foto = "/imgpaises/imgEUA/VidaNoturna/The Varnish (Los Angeles).png",
                        PaisId = 2,
                        Latitude = -34.04498032170264,
                        Longitude = -118.24956176438316
                },

                new Local () {
                        Id = 51,
                        Nome = "House Of Blues (Boston)",
                        Localizacao = "15 Lansdowne St, Boston",
                        Telefone = "+1 888-693-2583",
                        HorarioFuncionamento = "Abre todos os dias das 16 =00 até as 22 =00 e de quarta feira das 16 =00 até as 23 =00",
                        Descricao = "O Acessos muito práticos, wc em excelentes condições e sempre limpos. Zona de fumadores ao livre. Grande variedade de bebidas e acesso à area de merchandise. Excelente para concertos.",
                        Foto = "/imgpaises/imgEUA/VidaNoturna/House Of Blues (Boston).png",
                        PaisId = 2,
                        Latitude = -42.34763475441212,
                        Longitude = -71.0957312021085
                },

                new Local () {
                        Id = 52,
                        Nome = "Lafitte's Blacksmith Shop Bar (Nova Orleans)",
                        Localizacao = "15 Lansdowne St, Boston",
                        Telefone = "+1 888-693-2583",
                        HorarioFuncionamento = "Abre todos os dias das 16 =00 até as 22 =00 e de quarta feira das 16 =00 até as 23 =00",
                        Descricao = "O Acessos muito práticos, wc em excelentes condições e sempre limpos. Zona de fumadores ao livre. Grande variedade de bebidas e acesso à area de merchandise. Excelente para concertos.",
                        Foto = "/imgpaises/imgEUA/VidaNoturna/Lafitte's Blacksmith Shop Bar (Nova Orleans).png",
                        PaisId = 2,
                        Latitude = -29.961427885615436,
                        Longitude = -90.06349185432349
                },

                new Local () {
                        Id = 53,
                        Nome = "The Green Mill (Illinois)",
                        Localizacao = "4802 N Broadway, Chicago, IL 60640, EUA",
                        Telefone = "+1 773-878-5552",
                        HorarioFuncionamento = "Abre todos os dias das 16 =00 até as 04 =00",
                        Descricao = "O Green Mill é um lendário clube de jazz localizado no bairro de Uptown, em Chicago, Illinois. Fundado em 1907, o Green Mill é conhecido por sua rica história e por ser um dos poucos locais que sobreviveram à era da Lei Seca nos Estados Unidos. O clube era frequentado por gangsters famosos, como Al Capone, e ainda mantém seu charme e atmosfera de época. O Green Mill continua a ser um dos principais destinos para os amantes do jazz em Chicago, apresentando músicos locais e internacionais em um ambiente intimista e acolhedor.",
                        Foto = "/imgpaises/imgEUA/VidaNoturna/The Green Mill (Illinois).png",
                        PaisId = 2,
                        Latitude = -41.969349346834655,
                        Longitude = -87.65996760171761
                },

                new Local () {
                        Id = 54,
                        Nome = "Output (Brooklyn)",
                        Localizacao = "74 Wythe Ave, Brooklyn, NY 11249 ",
                        Telefone = "+1 773-878-5552",
                        HorarioFuncionamento = "Abre todos os dias das 16 =00 até as 04 =00",
                        Descricao = "O Output era uma casa noturna e clube de música eletrônica localizado em Williamsburg, Brooklyn. Conhecido por sua programação eclética de DJs e artistas internacionais, o Output era um destino popular para os amantes da música eletrônica em Nova York. O clube apresentava um sistema de som de alta qualidade e uma pista de dança espaçosa, criando uma experiência imersiva para os frequentadores. Infelizmente, o Output encerrou suas atividades em 2019, mas deixou uma marca duradoura na cena noturna de Nova York. ",
                        Foto = "/imgpaises/imgEUA/VidaNoturna/Output (Brooklyn).png",
                        PaisId = 2,
                        Latitude = -40.72239522095071,
                        Longitude = -73.95789761498503
                },
        #endregion

        #region EUA Espiritualidade
                new Local () {
                        Id = 55,
                        Nome = "Old Noren Church (Massachussets)",
                        Localizacao = "193 Salem St, Boston, MA 02113",
                        Telefone = "+1 617-523-6676",
                        HorarioFuncionamento = "Abre todos os dias das 10 =00 até as 17 =00 e de Domingo das 11 =00 até as 12 =00 e das 12 =30 até as 17 =00",
                        Descricao = "A Old North Church é uma igreja missionária episcopal localizada no bairro North End de Boston. A igreja, construída em 1723, é a igreja mais antiga de Boston e um marco histórico nacional. A Old North Church é famosa por seu papel no passeio noturno de Paul Revere em 18 de abril de 1775.",
                        Foto = "/imgpaises/imgEUA/Fe/Old Noren Church (Massachussets).png",
                        PaisId = 2,
                        Latitude = -42.44572879469477,
                        Longitude = -71.3154315560684
                },

                new Local () {
                        Id = 56,
                        Nome = "Catedral Nacional De Washignion (Washington)",
                        Localizacao = "3101 Wisconsin Ave NW, Washington, DC 20016, EUA",
                        Telefone = "(202) 537-6200",
                        HorarioFuncionamento = "Abre de segunda até sexta das 10 =00 até as 17 =00 e de final de semana das 08 =00 até as 18 =00",
                        Descricao = "A Catedral Nacional de Washington, oficialmente conhecida como Catedral Nacional da Igreja Episcopal de São Pedro e São Paulo, é uma das maiores catedrais do mundo e um marco histórico e arquitetônico importante em Washington, DC. A construção da catedral começou em 1907 e levou várias décadas para ser concluída. A catedral é conhecida por sua arquitetura gótica impressionante, vitrais deslumbrantes e por ser o local de muitos eventos religiosos e culturais significativos. A catedral também abriga uma variedade de artefatos e obras de arte preciosas, tornando-a um local de interesse não apenas para os fiéis, mas também para os entusiastas da história e da arquitetura. ional.",
                        Foto = "/imgpaises/imgEUA/Fe/Catedral Nacional De Washignion (Washington).png",
                        PaisId = 2,
                        Latitude = -38.930895056961006,
                        Longitude = -77.0708022576138
                },

                new Local () {
                        Id = 57,
                        Nome = "166n Street Baptist (Birmigan)",
                        Localizacao = "1530 6th Ave N, Birmingham, AL 35203",
                        Telefone = "+1 205-251-9402",
                        HorarioFuncionamento = "Abre todos os dias da semana das 09 =00 até as 17 =00",
                        Descricao = "A Igreja Batista da 16th Street foi organizada como a Primeira Igreja Batista de Cor de Birmingham em 1873. Foi a primeira igreja negra a se organizar em Birmingham, fundada apenas dois anos antes. As primeiras reuniões foram realizadas em um pequeno prédio na 12th Street com a Fourth Avenue North. Logo foi adquirido um terreno na 3ª Avenida Norte, entre as ruas 19 e 20, para um edifício dedicado. Em 1880, a igreja vendeu aquela propriedade e construiu uma nova igreja no local atual na 16th Street com a 6th Avenue North.",
                        Foto = "/imgpaises/imgEUA/Fe/166n Street Baptist (Birmigan).png",
                        PaisId = 2,
                        Latitude = -33.55641833007963,
                        Longitude = -86.65924951291068
                },

                new Local () {
                        Id = 58,
                        Nome = "San Xavier Del Bac (Tuuson)",
                        Localizacao = "1950 W San Xavier Rd, Tucson, AZ 85746",
                        Telefone = "(520) 294-2624",
                        HorarioFuncionamento = "Abre todos os dias das 09 =00 até as 16 =00",
                        Descricao = "San Xavier Del Bac, também conhecida como A Igreja Branca do Deserto, é uma igreja católica histórica localizada na reserva indígena Tohono O odham em Tucson, Arizona. A construção da igreja começou em 1783 e foi concluída em 1797. A igreja é conhecida por sua arquitetura barroca espanhola impressionante, sua fachada branca brilhante e seus detalhes decorativos elaborados. San Xavier Del Bac é um importante local de peregrinação e é considerada uma das igrejas mais bonitas e bem preservadas do sudoeste dos Estados Unidos.",
                        Foto = "/imgpaises/imgEUA/Fe/SanXavierDelBac(Tuuson).png",
                        PaisId = 2,
                        Latitude = -32.107457292025,
                        Longitude = -111.00871185927468
                },

                new Local () {
                        Id = 59,
                        Nome = "São Patricio (NY)",
                        Localizacao = "5th Ave, New York, NY 10022, EUA",
                        Telefone = "(212) 753-2261",
                        HorarioFuncionamento = "Abre todos os dias das 06 =30 até as 20 =45",
                        Descricao = "A Catedral de São Patrício é a maior catedral católica dos Estados Unidos e um dos marcos mais famosos de Nova York. Construída em estilo neogótico, a catedral é conhecida por suas impressionantes torres e vitrais. A catedral também é conhecida por abrigar o túmulo de muitos arcebispos de Nova York e por sediar eventos religiosos importantes. A catedral é um importante centro de peregrinação e turismo em Nova York, atraindo visitantes de todo o mundo.",
                        Foto = "/imgpaises/imgEUA/Fe/SãoPatricioNY).png",
                        PaisId = 2,
                        Latitude = -40.758775680936296,
                        Longitude = -73.9762399873193
                },

                new Local () {
                        Id = 60,
                        Nome = "Trinity Church (NY)",
                        Localizacao = "75 Broadway, New York, NY 10006",
                        Telefone = "(212) 602-0800",
                        HorarioFuncionamento = "Abre todos de segunda a sexta das 07 =00 até as 18 =00 e de final de semana das 08 =00 até as 16 =00",
                        Descricao = "A Trinity Church é uma igreja episcopal localizada no distrito financeiro de Manhattan, em Nova York. Fundada em 1697, a igreja é conhecida por sua arquitetura neogótica impressionante e por sua rica história. A Trinity Church desempenhou um papel importante na história de Nova York e é um marco histórico importante na cidade. Além de ser um local de culto, a igreja também é conhecida por suas atividades comunitárias e de caridade. A igreja também abriga um cemitério histórico onde estão enterradas várias figuras proeminentes da história americana.",
                        Foto = "/imgpaises/imgEUA/Fe/TrinityChurch(NY).png",
                        PaisId = 2,
                        Latitude = -40.76289629852705,
                        Longitude = -73.96416251400898
                },
        #endregion

        #region EUA Restaurantes
                new Local () {
                        Id = 61,
                        Nome = "Franklin Barbeyou (Austin)",
                        Localizacao = "900 E 11th St, Austin, TX 78702",
                        Telefone = "+1 512-653-1187",
                        HorarioFuncionamento = "Abre todos de terça a Domingo das 11 =00 até as 15 =00",
                        Descricao = "Longas filas se formam cedo para comprar briskets, carnes suína e outras opções defumadas neste local movimentado.",
                        Foto = "/imgpaises/imgEUA/Restaurantes/Franklin Barbeyou (Austin).png",
                        PaisId = 2,
                        Latitude = -30.27032096781963,
                        Longitude = -97.73137578358993
                },

                new Local () {
                        Id = 62,
                        Nome = "Joe's Stone Crab (Miami Beach)",
                        Localizacao = "11 Washington Ave, Miami Beach ",
                        Telefone = "+1 305-673-036",
                        HorarioFuncionamento = "Abre segunda até quinta feira das 11 =00 até as 22 =00, de sexta e sábado abre das 11 =30 as 23 =00 e de Domingo das 11 =30 até as 21 =00",
                        Descricao = "Joe's Stone Crab é um restaurante icônico localizado em Miami Beach, Flórida. Especializado em frutos do mar, com ênfase especial no caranguejo de pedra, o Joe's é conhecido por sua atmosfera animada e sua comida deliciosa. O restaurante é frequentemente visitado por moradores locais e turistas que buscam uma experiência gastronômica única.",
                        Foto = "cbvbcvb",
                        PaisId = 2,
                        Latitude = -25.769332721797984,
                        Longitude =  -80.13509683061656
                },

                new Local () {
                        Id = 63,
                        Nome = "French Laundry (Yountville)",
                        Localizacao = "6640 Washington St, Yountville",
                        Telefone = "+1 707 944 2380",
                        HorarioFuncionamento = "Abre de terça até sábado das 18 =30 até as 22 =00",
                        Descricao = "A Lavanderia Francesa é um restaurante requintado de culinária francesa e californiana com três estrelas Michelin. Fundado em 1994 pelo chef Thomas Keller, o restaurante é conhecido por seus menus degustação sazonais, que apresentam ingredientes frescos e da estação.expand_more A Lavanderia Francesa também possui uma extensa carta de vinhos, com mais de 1.000 rótulos de todo o mundo.",
                        Foto = "/imgpaises/imgEUA/Restaurantes/French Laundry (Yountville).png",
                        PaisId = 2,
                        Latitude = -38.404672556142536,
                        Longitude = -122.36513570963119
                },

                new Local () {
                        Id = 64,
                        Nome = "Per Se (NY)",
                        Localizacao = "10 Columbus Cir, New York ",
                        Telefone = "+1 212 823 9335",
                        HorarioFuncionamento = "Abre de terça até sábado das 17 =30 até as 22 =00",
                        Descricao = "O Per Se é um restaurante requintado de culinária francesa moderna com três estrelas Michelin. Fundado em 2004 pelo chef Thomas Keller, o restaurante é conhecido por seus menus degustação sazonais, que apresentam ingredientes frescos e da estação. O Per Se também possui uma extensa carta de vinhos, com mais de 1.000 rótulos de todo o mundo.",
                        Foto = "/imgpaises/imgEUA/Restaurantes/Per Se (NY).png",
                        PaisId = 2,
                        Latitude = -40.76845715651663,
                        Longitude = -73.98317348115653
                },

                new Local () {
                        Id = 65,
                        Nome = "Camilas (Orlando, FL)",
                        Localizacao = "5458 International Dr, Orlando, FL 32819, EUA",
                        Telefone = "+1 407-354-2507",
                        HorarioFuncionamento = "Abre de segunda a domingo, das 11h até as 23h",
                        Descricao = "Restaurante simples e espaçoso com buffet de comida brasileira, incluindo ensopados em algumas noites.",
                        Foto = "/imgpaises/imgEUA/Restaurantes/Camila's.png",
                        PaisId = 2,
                        Latitude = -40.76158606813773,
                        Longitude = -73.9818736684916
                },

                new Local () {
                        Id = 66,
                        Nome = "The Dutch (NY)",
                        Localizacao = "131 Sullivan St, New York, NY 10012, EUA",
                        Telefone = "+1 212-677-6200",
                        HorarioFuncionamento = "Abre de segunda a sexta, das 12h até as 22h, sábado e domingo, das 10h até as 23h",
                        Descricao = "Comida americana regional, incluindo ostras e frango frito muito elogiado, em um ambiente animado e moderno.",
                        Foto = "/imgpaises/imgEUA/Restaurantes/The dutch.png",
                        PaisId = 2,
                        Latitude = -41.91393000087764,
                        Longitude = -87.64806430544648
                },
                #endregion

                #region EUA Cultura
                new Local () {
                        Id = 67,
                        Nome = "Independece National Historical Park (Filadelfía)",
                        Localizacao = "143 S 3rd St, Philadelphia",
                        Telefone = "+1 215 965 2300",
                        HorarioFuncionamento = "Abre todos os dias das 09 =00 até as 17 =00",
                        Descricao = "O Independence National Historical Park é um parque histórico nacional que preserva vários locais associados à Revolução Americana e à história da fundação dos Estados Unidos. O parque abriga o Independence Hall, onde a Declaração da Independência e a Constituição dos Estados Unidos foram debatidas e adotadas.",
                        Foto = "/imgpaises/imgEUA/Cultura/Independece National Historical Park (Filadelfía).png",
                        PaisId = 2,
                        Latitude = -40.49968903347103,
                        Longitude = -75.16705952368153
                },

                new Local () {
                        Id = 68,
                        Nome = "Alcatraz Island (São Francisco)",
                        Localizacao = "Pier 33, Alcatraz Island",
                        Telefone = "+1 415 561 4900",
                        HorarioFuncionamento = "Abre todos os dias das 09 =00 até as 17 =00",
                        Descricao = "A Ilha de Alcatraz é uma ilha rochosa localizada na Baía de São Francisco, na Califórnia. A ilha já foi um forte militar, uma prisão federal e agora é um parque nacional. A prisão de Alcatraz é uma das atrações turísticas mais populares de São Francisco.",
                        Foto = "/imgpaises/imgEUA/Cultura/Alcatraz Island (São Francisco).png",
                        PaisId = 2,
                        Latitude = -32.68402996216141,
                        Longitude = -104.26023604562027
                },

                new Local () {
                        Id = 69,
                        Nome = "National Civil Right Museum (Tenesse)",
                        Localizacao = "50 Mulberry St, Memphis",
                        Telefone = "+1 901 521 9699",
                        HorarioFuncionamento = "Abre de segunda até sábado das 09 =00 até as 17 =00 e de Domingo das 12 =00 até as 17 =00",
                        Descricao = "O Museu Nacional dos Direitos Civis é um museu dedicado à história do movimento dos direitos civis nos Estados Unidos. O museu está localizado em Memphis, Tennessee, no local do Lorraine Motel, onde o Dr. Martin Luther King Jr. foi assassinado em 1968.",
                        Foto = "/imgpaises/imgEUA/Cultura/National Civil Right Museum (Tenesse).png",
                        PaisId = 2,
                        Latitude = -35.134766014551566,
                        Longitude = -90.05780276313489
                },

                new Local () {
                        Id = 70,
                        Nome = "Gettysburg National Military Park (Pensilvania)",
                        Localizacao = "1195 Baltimore Pike, Gettysburg",
                        Telefone = "+1 717 334 1124",
                        HorarioFuncionamento = "Abre todos os dias das 08 =00 até as 17 =00",
                        Descricao = "O Parque Militar Nacional de Gettysburg preserva o campo de batalha da Batalha de Gettysburg, travada de 1 a 3 de julho de 1863, durante a Guerra Civil Americana. A batalha foi a mais sangrenta da guerra e um ponto de virada no conflito. O parque abrange mais de 6.000 acres de campos de batalha, monumentos e memoriais.",
                        Foto = "/imgpaises/imgEUA/Cultura/Gettysburg National Military Park (Pensilvania).png",
                        PaisId = 2,
                        Latitude = -39.80554670925124,
                        Longitude = -77.24211138949524
                },

                new Local () {
                        Id = 71,
                        Nome = "Mount Rushmore (Reystone)",
                        Localizacao = "13000 S Dakota Hwy 244, Keystone",
                        Telefone = "+1 605 574 2523",
                        HorarioFuncionamento = "Abre todos os dias das 05 =00 até as 00 =00",
                        Descricao = "O Monte Rushmore é um monumento esculpido em uma montanha de granito no estado americano de Dakota do Sul. O monumento apresenta os rostos de quatro presidentes dos Estados Unidos = George Washington, Thomas Jefferson, Theodore Roosevelt e Abraham Lincoln.",
                        Foto = "/imgpaises/imgEUA/Cultura/Mount Rushmore (Reystone).png",
                        PaisId = 2,
                        Latitude = -43.88066836781004,
                        Longitude = -103.4538637851712
                },

                new Local () {
                        Id = 72,
                        Nome = "Pearl Harbour (Havaí)",
                        Localizacao = "1000 Kamehameha Hwy, Honolulu",
                        Telefone = " +1 808-422-3399",
                        HorarioFuncionamento = "Abre todos os dias das 07 =00 até as 17 =00",
                        Descricao = "Pearl Harbor é um porto natural na ilha de Oahu, no Havaí. Foi o local do ataque japonês aos Estados Unidos em 7 de dezembro de 1941, que precipitou a entrada dos Estados Unidos na Segunda Guerra Mundial. O porto abriga agora várias instalações militares, bem como o USS Arizona Memorial, o USS Missouri Memorial e o Pearl Harbor Aviation Museum.",
                        Foto = "/imgpaises/imgEUA/Cultura/Pearl Harbour (Havaí).png",
                        PaisId = 2,
                        Latitude = -21.356943711342474,
                        Longitude = -157.9804704615852
                },
                #endregion
        #endregion
        
        #region França
                // 73 a 108
                #region FR Natureza
                        new Local() {
                        Id = 73,
                        Nome = "Parque Nacional de Ecrins (Alpes Franceses)",
                        Localizacao ="Maison du Parc, Domaine de Charance.",
                        Telefone = "+33 492235400.",
                        HorarioFuncionamento= "Abre de Segunda até sexta das 09:00 às 12:00 e depois das 14:00 até as 18:00.",
                        Descricao = "O Parque Nacional de Écrins é um parque nacional francês localizado nos Alpes franceses. É o maior parque nacional da França, com uma área de 918.000 hectares. O parque abriga uma variedade de paisagens, incluindo montanhas, geleiras, lagos e florestas. O parque também abriga uma variedade de vida selvagem, incluindo íbex, cabras selvagens, marmotas e aves de rapina.",
                        Foto = "/imgpaises/imgFranca/Natureza/Parque Nacional de Ecrins (Alpes Franceses).png",
                        PaisId = 3,
                        Latitude = -44.92145154850825,
                        Longitude = -6.335895541146967
                },

                        new Local() {
                        Id = 74,
                        Nome = "Parc Zoologique de Paris (Paris)",
                        Localizacao ="53 Avenue Daumesnil, 75012 Paris.",
                        Telefone = "+33 140729524.",
                        HorarioFuncionamento= "Aberto todos os dias do ano, exceto 25 de dezembro e 1º de janeiro, das 9h30 às 18h (última entrada às 17h15).",
                        Descricao = "O Parc Zoologique de Paris, também conhecido como Zoo de Vincennes, é um parque zoológico localizado no 12º arrondissement de Paris, França. É um dos maiores zoos da Europa, com mais de 2.000 animais de 250 espécies diferentes. O zoo está dividido em cinco biozonas: Patagônia, Europa, Madagascar, Planície Africana e Amazônia-Guiana.",
                        Foto = "/imgpaises/imgFranca/Natureza/Parc Zoologique de Paris (Paris).png",
                        PaisId = 3,
                        Latitude = -48.83356464087311,
                        Longitude = -2.414438883604537
                },

                        new Local() {
                        Id = 75,
                        Nome = "Parc de la Tête d'Or (Lyon)",
                        Localizacao ="1 Rue du Premier-Mars 1871, 69006 Lyon.",
                        Telefone = "+33 472605300.",
                        HorarioFuncionamento= "Das 7h às 20h (de novembro a abril) e das 6h30 às 21h (de maio a outubro).",
                        Descricao = "O Parc de la Tête d'Or é um parque urbano exuberante e extenso situado no coração de Lyon, França. Com seus 117 hectares de área verde, oferece um refúgio natural para os habitantes da cidade e visitantes, proporcionando uma variedade de atividades para todos os gostos e idades.",
                        Foto = "/imgpaises/imgFranca/Natureza/Parc de la Tête d'Or (Lyon).png",
                        PaisId = 3,
                        Latitude = -45.77732937604459,
                        Longitude = -4.854969737402913
                },

                        new Local() {
                        Id = 76,
                        Nome = "Parque Natural Regional de Camargue (Provença-Alpes-Costa Azul)",
                        Localizacao =" Maison du Parc, 13200 Arles.",
                        Telefone = "+33 4 90974040.",
                        HorarioFuncionamento= "De Segunda a Sexta das 09:00 às 12:00 e depois das 14:00 até as 18:00.",
                        Descricao = "O Parque Natural Regional de Camargue é uma área úmida protegida localizada no sul da França, na região da Provença-Alpes-Costa Azul. O parque abriga uma variedade de paisagens, incluindo pântanos, salinas, dunas e florestas. O parque também é o lar de uma grande variedade de vida selvagem, incluindo flamingos, cavalos selvagens e touros negros.",
                        Foto = "/imgpaises/imgFranca/Natureza/Parque Natural Regional de Camargue (Provença-Alpes-Costa Azul).png",
                        PaisId = 3,
                        Latitude = -43.5260403794442,
                        Longitude = -4.6080163027644625
                },

                        new Local() {
                        Id = 77,
                        Nome = "Jardim Botânico de Bordéus (Bordéus)",
                        Localizacao =" Rue du Jardin Public, 33000 Bordeaux.",
                        Telefone = "+33 556524217.",
                        HorarioFuncionamento= "Das 7h30 às 20h (de abril a setembro) e das 8h às 18h (de outubro a março).",
                        Descricao = "O Jardim Botânico de Bordéus é um jardim botânico público com uma área de 11 hectares. Fundado em 1629, é um dos mais antigos jardins botânicos da França. O jardim abriga uma coleção de mais de 3.000 espécies de plantas de todo o mundo, incluindo plantas tropicais, subtropicais e temperadas. O jardim também possui um herbário com mais de 100.000 espécimes de plantas.",
                        Foto = "/imgpaises/imgFranca/Natureza/Jardim Botânico de Bordéus  (Bordéus).png",
                        PaisId = 3,
                        Latitude = -44.84989373271244,
                        Longitude = -0.580033335018285
                },

                new Local() {
                        Id = 78,
                        Nome = "Parc Zoologique de La Palmyre (Royan)",
                        Localizacao ="Route de Royan, 17570 Les Mathes",
                        Telefone = "+33 5 46 22 46 46",
                        HorarioFuncionamento= "Abre de Segunda até sexta das 09:00 às 12:00 e depois das 14:00 até as 18:00",
                        Descricao = "O Parc Zoologique de La Palmyre é um zoológico particular com uma área de 18 hectares. Fundado em 1966, é um dos maiores zoológicos da França. O zoológico abriga uma coleção de mais de 1.600 animais de 115 espécies diferentes, incluindo mamíferos, aves, répteis e anfíbios. O zoológico também possui um parque aquático com shows de leões marinhos e focas.",
                        Foto = "/imgpaises/imgFranca/Natureza/Parc Zoologique de La Palmyre (Royan).png",
                        PaisId = 3,
                        Latitude = -45.686120937739126,
                        Longitude = -1.1667513390495499
                },
                #endregion

                #region FR Compras
                new Local() {
                        Id = 79,
                        Nome = "Les Halles de Lyon - Paul Bocuse (Lyon)",
                        Localizacao ="102 Cours Lafayette, 69003 Lyon",
                        Telefone = "+33 4 72405757",
                        HorarioFuncionamento= "De Segunda a sábado das 7h às 22h30 e de Domingo das 7h às 14h30",
                        Descricao = "As Halles de Lyon - Paul Bocuse, um mercado gastronômico coberto com mais de 13.000 m², é um dos principais pontos turísticos de Lyon e um paraíso para os amantes da gastronomia. Inaugurado em 1859 e reaberto em 2006 após uma extensa reforma, o mercado recebeu o nome do famoso chef francês Paul Bocuse, um frequentador assíduo e defensor da culinária local.",
                        Foto = "/imgpaises/imgFranca/Compras/Les Halles de Lyon - Paul Bocuse (Lyon).png",
                        PaisId = 3,
                        Latitude = -45.76288641199138,
                        Longitude = -4.850205254605206
                },

                new Local() {
                        Id = 80,
                        Nome = "Val d'Europe",
                        Localizacao ="Boulevard circulaire, 77700 Serris.",
                        Telefone = "+33 1 60434040",
                        HorarioFuncionamento= "De Segunda a sábado das 10h às 20h30 e de Domingo das 10h às 20h",
                        Descricao = "O Centre Commercial Val d'Europe é um dos maiores centros comerciais da Europa, com mais de 190 lojas e 30 restaurantes. Localizado em Marne-la-Vallée, a apenas 5 minutos de Disneyland Paris, o centro comercial é um destino popular para compras, alimentação e entretenimento.",
                        Foto = "/imgpaises/imgFranca/Compras/Centre Commercial Val d'Europe (Marne-la-Vallée).png",
                        PaisId = 3,
                        Latitude = -48.85524003682555,
                        Longitude = -2.7780312394225404
                },

                new Local() {
                        Id = 81,
                        Nome = " Marché de la Bastille (Lyon)",
                        Localizacao ="Boulevard Richard Lenoir, 75011 Paris",
                        Telefone = "De Quinta-feira das  7h às 14h30 e de Domingo das 7h às 15h",
                        HorarioFuncionamento= "De Segunda a sábado das 10h às 20h30 e de Domingo das 10h às 20h",
                        Descricao = "O Marché de la Bastille é um mercado de rua tradicional que acontece no Boulevard Richard Lenoir, em frente à Place de la Bastille, em Paris. O mercado existe desde o século XIX e é um dos maiores mercados de rua da cidade.",
                        Foto = "/imgpaises/imgFranca/Compras/Marché de la Bastille (Paris).png",
                        PaisId = 3,
                        Latitude = -48.9189737896989,
                        Longitude = -2.3816819888970446
                },

                new Local() {
                        Id = 82,
                        Nome = "Passage Pommeraye (Nantes)",
                        Localizacao ="Maison du Parc, Domaine de Charance.",
                        Telefone = "+33 492235400.",
                        HorarioFuncionamento= "Abre de Segunda até sexta das 09:00 às 12:00 e depois das 14:00 até as 18:00.",
                        Descricao = "O Parque Nacional de Écrins é um parque nacional francês localizado nos Alpes franceses. É o maior parque nacional da França, com uma área de 918.000 hectares. O parque abriga uma variedade de paisagens, incluindo montanhas, geleiras, lagos e florestas. O parque também abriga uma variedade de vida selvagem, incluindo íbex, cabras selvagens, marmotas e aves de rapina.",
                        Foto = "/imgpaises/imgFranca/Compras/Passage Pommeraye (Nantes).png",
                        PaisId = 3,
                        Latitude = -47.21367708932783,
                        Longitude =  -1.5596807029923423
                },

                new Local() {
                        Id = 83,
                        Nome = "Les Docks Village (Marselha)",
                        Localizacao ="10 Place de la Joliette, 13002 Marseille ",
                        Telefone = "+33 484359090 ",
                        HorarioFuncionamento= "Segunda a sábado das 10h às 20h de Domingo das11h às 19h.",
                        Descricao = "Les Docks Village é um centro comercial e de lazer localizado no coração de Marselha, na França. O centro comercial está situado em um antigo armazém portuário do século XIX, que foi completamente renovado e modernizado.",
                        Foto = "/imgpaises/imgFranca/Compras/Les Docks Village (Marselha).png",
                        PaisId = 3,
                        Latitude = -43.307171894237776,
                        Longitude = -5.366295967971776
                },

                new Local() {
                        Id = 84,
                        Nome = "Village Royal (Paris)",
                        Localizacao ="2 Rue Royale, 75008 Paris",
                        Telefone = "+33 142603131  ",
                        HorarioFuncionamento= "Segunda a sábado das10h às 20h de Domingo das 11h às 19h ",
                        Descricao = "O Village Royal é um centro comercial de luxo localizado no coração de Paris, na França. O centro comercial está situado em um antigo convento do século XVII, que foi completamente renovado e modernizado. ",
                        Foto = "/imgpaises/imgFranca/Compras/Village Royal (Paris).png",
                        PaisId = 3,
                        Latitude = -48.8695121149803,
                        Longitude = -2.3223143682599248
                },
                #endregion

                #region FR Vida Noturna
                new Local() {
                        Id = 85,
                        Nome = "Montmarte e Pigalle (Paris) ",
                        Localizacao ="75018 Paris, França",
                        Telefone = "Não Tem  ",
                        HorarioFuncionamento= "Todos os dias das 10h até as 18h. ",
                        Descricao = "Montmartre é um bairro conhecido por sua atmosfera boêmia e artística. A Basílica do Sacré-Coeur, localizada no topo da colina de Montmartre, é um dos principais pontos turísticos do bairro. Outros pontos de interesse incluem o Moulin Rouge, o Museu de Montmartre e a Place du Tertre.  ",
                        Foto = "/imgpaises/imgFranca/VidaNoturna/Montmarte e Pigalle (Paris).png",
                        PaisId = 3,
                        Latitude = -48.85110946488163,
                        Longitude = -2.344838839643606
                },

                new Local() {
                        Id = 86,
                        Nome = "La Cité du Vin (Bordeaux)   ",
                        Localizacao ="134 Quai de Bacalan, 33000 Bordeaux",
                        Telefone = "+33 556002020  ",
                        HorarioFuncionamento= "Aberto todos os dias das 10h até as 18h e fechado nos dias 22 a 28 de janeiro. ",
                        Descricao = "La Cité du Vin é um museu cultural e centro de exposições dedicado ao vinho, localizado em Bordeaux, França. Inaugurado em 2016, o museu oferece uma experiência imersiva e sensorial, explorando a história, a produção e o impacto cultural do vinho em todo o mundo.",
                        Foto = "/imgpaises/imgFranca/VidaNoturna/La Cité du Vin (Bordeaux).png",
                        PaisId = 3,
                         Latitude = -44.86253144963628,
                        Longitude = -0.5505678589308564
                },

                new Local() {
                        Id = 87,
                        Nome = "L'Usine (Istres)",
                        Localizacao ="442 Rue du 8 Mai 1945, 13800 Istres",
                        Telefone = "+33 442560221",
                        HorarioFuncionamento= "Aberto de terça até sexta das 14h até as 18h, de sábado das 10h até as 18h e de final de semana fechado.",
                        Descricao = "L'Usine, em Istres, é mais do que um centro cultural. É um espaço vibrante e acolhedor que pulsa com a energia da cultura e das artes em todas as suas formas. Mais do que um local para eventos, L'Usine é uma comunidade vibrante que conecta artistas, criadores e público em um ambiente único e inspirador. ",
                        Foto = "/imgpaises/imgFranca/VidaNoturna/L'Usine (Istres).png",
                        PaisId = 3,
                         Latitude = -43.4915355251203,
                        Longitude = -4.969446696817481
                },

                new Local() {
                        Id = 88,
                        Nome = "Grands Boulevards (Paris)",
                        Localizacao ="Boulevard Montmartre, 75008 Paris",
                        Telefone = "Não tem",
                        HorarioFuncionamento= "Aberto de todos os dias e 24h por dia.",
                        Descricao = "Os Grands Boulevards são uma área vibrante e movimentada de Paris, com uma grande variedade de lojas, restaurantes, cafés, teatros e cinemas. A área é um popular destino turístico, especialmente para quem gosta de fazer compras, observar as pessoas e experimentar a cultura parisiense. ",
                        Foto = "/imgpaises/imgFranca/VidaNoturna/Grands Boulevards (Paris).png",
                        PaisId = 3,
                         Latitude = -48.87033683447378,
                        Longitude = -2.3465661888531213
                },

                new Local() {
                        Id = 89,
                        Nome = "Le Batofar (Paris)  ",
                        Localizacao = "11 Quai Charles Pasqua, 75013 Paris ",
                        Telefone = "+33 140405024",
                        HorarioFuncionamento= "Aberto de quarta até sexta 19h até as 2h, de sábado das 12h até as 2h, de Domingo das 12h até as 0h e fechado de segunda e terça. ",
                        Descricao = "Le Batofar é um barco-clube e sala de concertos flutuante no Rio Sena, em Paris. A embarcação, que já foi um farol holandês, oferece uma experiência única de música ao vivo e DJs em um ambiente descontraído e alternativo. ",
                        Foto = "/imgpaises/imgFranca/VidaNoturna/Le Batofar (Paris).png",
                        PaisId = 3,
                         Latitude = -48.833458854372715,
                        Longitude = -2.3790488970946067
                },

                new Local() {
                        Id = 90,
                        Nome = "Champs-Élysées (Paris) ",
                        Localizacao = "Avenue des Champs-Élysées  ",
                        Telefone = "Não tem",
                        HorarioFuncionamento= "Aberto de segunda até sábado das 10h até as 20h. ",
                        Descricao = "A Champs-Élysées é uma das avenidas mais famosas do mundo, conhecida por suas lojas luxuosas, cafés charmosos, monumentos históricos e atmosfera vibrante. É um local popular para turistas e parisienses, oferecendo uma variedade de atividades para todos os gostos.  ",
                        Foto = "/imgpaises/imgFranca/VidaNoturna/Champs-Élysées (Paris).png",
                        PaisId = 3,
                         Latitude = -48.873143644833625,
                        Longitude = -2.297884783606711
                },
                #endregion

                #region FR Espiritualidade
                new Local() {
                        Id = 91,
                        Nome = "Catedral de Notre-Dame de Paris (Paris)",
                        Localizacao = "6 Parvis Notre-Dame - Place Jean-Paul II, 75004 Paris ",
                        Telefone = "+33 142345610",
                        HorarioFuncionamento= "Previsão de reabertura em 2024.",
                        Descricao = "A Catedral de Notre-Dame de Paris é uma das catedrais góticas mais famosas do mundo. Construída entre os séculos XII e XIII, é considerada uma obra-prima da arquitetura gótica e um símbolo da cultura francesa. A catedral é dedicada à Virgem Maria e é um importante local de peregrinação católica.  ",
                        Foto = "/imgpaises/imgFranca/Fe/Catedral de Notre-Dame de Paris (Paris).png",
                        PaisId = 3,
                         Latitude = -48.85311642072675,
                        Longitude = -2.349869910585774,
                },

                new Local() {
                        Id = 92,
                        Nome = "Catedral de Chartres (Chartres)",
                        Localizacao = "16 Rue Saint-Pierre, 28000 Chartres",
                        Telefone = "+33 237218585",
                        HorarioFuncionamento= "De segunda até sábado das 8:30h até as 19h e de Domingo e feriados das 12h até as 19h.",
                        Descricao = "A Catedral de Chartres é uma catedral gótica francesa considerada Patrimônio Mundial da UNESCO. Construída entre os séculos XII e XIII, é um dos mais belos exemplos da arquitetura gótica e um importante local de peregrinação mariana. ",
                        Foto = "/imgpaises/imgFranca/Fe/Catedral de Chartres (Chartres).png",
                        PaisId = 3,
                         Latitude = -48.447944900267856,
                        Longitude = -1.487772724053863
                },

                new Local() {
                        Id = 93,
                        Nome = "Basílica de Saint-Denis (Saint-Denis)",
                        Localizacao = "1 Rue de la Légion d'Honneur, 93200 Saint-Denis ",
                        Telefone = "+33 148098311",
                        HorarioFuncionamento= "De terça até domingo das 10h até as 18h e fechado de segunda.",
                        Descricao = "A Basílica de Saint-Denis é uma igreja gótica francesa e necrópole real, considerada Patrimônio Mundial da UNESCO. Construída entre os séculos XII e XIII, é um dos primeiros exemplos da arquitetura gótica e o local de sepultamento de 43 reis e 32 rainhas da França. ",
                        Foto = "/imgpaises/imgFranca/Fe/Basílica de Saint-Denis (Saint-Denis).png",
                        PaisId = 3,
                         Latitude = -48.93582777999544,
                        Longitude = -2.3590846105902665
                },

                new Local() {
                        Id = 94,
                        Nome = "Abadia de Mont Saint-Michel (Mont Saint-Michel) ",
                        Localizacao = "50170 Le Mont-Saint-Michel  ",
                        Telefone = "+33 233601414",
                        HorarioFuncionamento= "Em 1º de abril a 30 de setembro: 9h às 19h e em 1º de outubro a 31 de março: 9h30 às 18h. ",
                        Descricao = "A Abadia do Monte Saint-Michel é um mosteiro beneditino e um importante local de peregrinação, situado em uma ilha rochosa na costa da Normandia, França. A abadia foi fundada no século VIII e é um dos exemplos mais notáveis da arquitetura românica e gótica. ",
                        Foto = "/imgpaises/imgFranca/Fe/Abadia de Mont Saint-Michel (Mont Saint-Michel).png",
                        PaisId = 3,
                         Latitude = -48.63604195188945,
                        Longitude = -1.511686858732928
                },

                new Local() {
                        Id = 95,
                        Nome = "Catedral de Saint-Pierre de Beauvais (Beauvais)  ",
                        Localizacao = "2 Rue Saint-Pierre, 60000 Beauvais ",
                        Telefone = "+33 344481244",
                        HorarioFuncionamento= "De Segunda a sábado: 9h30 às 12h30 e 14h às 17h30 e de Domingo e feriados: 14h às 17h30.  ",
                        Descricao = "A Catedral de Saint-Pierre de Beauvais é uma catedral gótica francesa, considerada Patrimônio Mundial da UNESCO. Começada no século XIII, é a catedral mais alta da França e a segunda mais alta do mundo, com coro a 48,5 metros de altura. A catedral é um importante local de peregrinação mariana.  ",
                        Foto = "/imgpaises/imgFranca/Fe/Catedral de Saint-Pierre de Beauvais (Beauvais).png",
                        PaisId = 3,
                         Latitude = -49.43265650035901,
                        Longitude = -2.081505198983873
                },

                new Local() {
                        Id = 96,
                        Nome = "Basílica de Saint-Sernin (Toulouse)   ",
                        Localizacao = "Place Saint-Sernin, 31000 Toulouse ",
                        Telefone = "+33 561223544",
                        HorarioFuncionamento= "De Segunda a sábado: 10h às 12h30 e 14h às 18h e de Domingo e feriados: 14h às 18h.  ",
                        Descricao = "A Basílica de Saint-Sernin é uma igreja românica francesa, considerada Patrimônio Mundial da UNESCO. Construída entre os séculos XI e XIII, é a maior igreja românica conservada na Europa e um importante local de peregrinação no Caminho de Santiago.  ",
                        Foto = "/imgpaises/imgFranca/Fe/Basílica de Saint-Sernin (Toulouse).png",
                        PaisId = 3,
                         Latitude = -43.60840879240253,
                        Longitude = -1.4417931679865859
                },
                #endregion

                #region FR Restaurantes
                new Local() {
                        Id = 97,
                        Nome = "Ladurée (Paris)   ",
                        Localizacao = "75 Av. des Champs-Élysées, 75008 Paris ",
                        Telefone = "+33 140750875",
                        HorarioFuncionamento= "De Segunda a sábado: 8h às 21h30 e de Domingo: 8h às 20h30.  ",
                        Descricao = "A Ladurée é uma confeitaria francesa fundada em 1862, famosa por seus macarons coloridos e deliciosos. A loja da Champs-Élysées é a mais famosa da marca e oferece uma grande variedade de doces, chocolates, chás e outros produtos gourmet.  ",
                        Foto = "/imgpaises/imgFranca/Restaurantes/Ladurée (Paris).png",
                        PaisId = 3,
                         Latitude = -48.87305617486467,
                        Longitude = -2.302579633390368
                },

                new Local() {
                        Id = 98,
                        Nome = "Bustronome Paris (Paris)  ",
                        Localizacao = "2 Avenue Kléber, 75016 Paris ",
                        Telefone = "+33 142891919",
                        HorarioFuncionamento= "Almoço das 12h às 14h30 (segunda a sexta), Jantar das 19h às 22h30 (todos os dias) e o Cruzeiro com brunch das 11h às 14h (sábado e domingo)  ",
                        Descricao = "O Bustronome Paris é um restaurante único que oferece uma experiência gastronômica com vista para os principais pontos turísticos da cidade. A bordo de um ônibus de dois andares com teto de vidro, você pode desfrutar de um menu gourmet enquanto aprecia a vista da Torre Eiffel, do Arco do Triunfo, da Catedral de Notre Dame e de muitos outros lugares.  ",
                        Foto = "/imgpaises/imgFranca/Restaurantes/Bustronome Paris.png",
                        PaisId = 3,
                         Latitude = -48.87290790540156,
                        Longitude = -2.293862239423501
                },

                new Local() {
                        Id = 99,
                        Nome = "La Crêperie de la Dentellière (Dinan)   ",
                        Localizacao = "5 Rue de la Croix, 22100 Dinan ",
                        Telefone = "+33 296334448",
                        HorarioFuncionamento= "Terça a sábado das 12h às 14h e depois das 19h às 21h30, de Domingo das 12h às 14h e Fechado de Segunda-feira  ",
                        Descricao = "A La Crêperie de la Dentellière é uma creperia tradicional francesa localizada na charmosa cidade medieval de Dinan. A creperia oferece uma grande variedade de crepes doces e salgados, feitos com ingredientes frescos e de alta qualidade. ",
                        Foto = "/imgpaises/imgFranca/Restaurantes/La Crêperie de la Dentellière (Dinan).png",
                        PaisId = 3,
                         Latitude = -48.45355315541805,
                        Longitude = -2.043992710599298
                },

                new Local() {
                        Id = 100,
                        Nome = "Le Petit Nice (Marseille)    ",
                        Localizacao = "Corniche Kennedy, 13007 Marseille ",
                        Telefone = "+33 491592592",
                        HorarioFuncionamento= "No Almoço das 12h às 14h (terça a sexta), no Jantar das 19h às 22h (terça a sexta) e no Fim de semana: Aberto para almoço e janta  ",
                        Descricao = "Le Petit Nice é um restaurante com estrela Michelin, situado em uma bela vila à beira-mar em Marselha. O restaurante oferece uma vista deslumbrante da Baía de Marselha e do Château d'If. A cozinha é comandada pelo chef Gérald Passedat, que utiliza ingredientes frescos e sazonais do Mediterrâneo para criar pratos inovadores e saborosos.  ",
                        Foto = "/imgpaises/imgFranca/Restaurantes/Le Petit Nice (Marseille).png",
                        PaisId = 3,
                         Latitude = -43.28021845307651,
                        Longitude = -5.352078581460569
                },

                new Local() {
                        Id = 101,
                        Nome = "Maison de la Truffe (Sarlat-la-Canéda)",
                        Localizacao = "45 Rue de la République, 24200 Sarlat-la-Canéda ",
                        Telefone = "+33 553312494",
                        HorarioFuncionamento= "De Segunda a sábado das 9h30 às 12h30 e depois das 14h30 às 19h e de  Domingo das 10h às 12h30 e  depois 14h30 às 18h. ",
                        Descricao = "A Maison de la Truffe é uma loja especializada em trufas, localizada na charmosa cidade de Sarlat-la-Canéda, na região da Dordonha, na França. A loja oferece uma grande variedade de produtos à base de trufas, incluindo trufas frescas, conservas, óleos, cremes e chocolates.   ",
                        Foto = "/imgpaises/imgFranca/Restaurantes/Maison de la Truffe (Sarlat-la-Canéda).png",
                        PaisId = 3,
                         Latitude = -44.88168570451867,
                        Longitude = -1.2171629257235212
                },

                new Local() {
                        Id = 102,
                        Nome = "Chez Dumonet (Paris)",
                        Localizacao = "9 Rue Notre Dame de Lorette, 75009 Paris",
                        Telefone = "+33 145485794",
                        HorarioFuncionamento= "De Segunda a sexta das 12h30 às 14h30 e depois das 19h30 às 22h30, de Sábado das12h30 às 14h30 e depois 19h30 às 23h e de Domingo: Fechado",
                        Descricao = "O Chez Dumonet é um restaurante tradicional francês, localizado no charmoso bairro de Montmartre em Paris. O restaurante oferece uma atmosfera acolhedora e um menu clássico de pratos franceses, como confit de canard, boeuf bourguignon e ratatouille. ",
                        Foto = "/imgpaises/imgFranca/Restaurantes/Chez Dumonet (Paris).png",
                        PaisId = 3,
                         Latitude = -48.84596688395662,
                        Longitude = -2.3198274817487
                },
                #endregion

                #region FR Cultura
                new Local() {
                        Id = 103,
                        Nome = "Palácio de Versalhes (Versalhes) ",
                        Localizacao = "Place d'Armes, 78000 Versailles ",
                        Telefone = "+33 130837800" ,
                        HorarioFuncionamento= "De Terça a domingo das 9h às 18h30 (última entrada às 18h) e Fechado de Segundas-feiras, 1º de janeiro, 1º de maio e 25 de dezembro ",
                        Descricao = "O Palácio de Versalhes é um dos maiores e mais opulentos palácios do mundo. Foi a residência oficial dos reis da França de 1682 a 1789 e é um símbolo do poder e da riqueza da monarquia francesa. O palácio está situado em uma vasta propriedade que inclui jardins, parques e florestas.  ",
                        Foto = "/imgpaises/imgFranca/Cultura/Palácio de Versalhes (Versalhes).png",
                        PaisId = 3,
                         Latitude = -48.80502739563556,
                        Longitude = -2.1203124817464847
                },

                new Local() {
                        Id = 104,
                        Nome = "Torre Eiffel (Paris) ",
                        Localizacao = "Champ de Mars, 5 Avenue Anatole France, 75007 Paris ",
                        Telefone = "+33 892701239" ,
                        HorarioFuncionamento= "Elevador ao 2º andar das 9h às 23h45 (de setembro a junho) / 9h à 0h45 (de julho a agosto), Elevador ao topo das 9h15 às 23h15 (de setembro a junho) / 9h15 à 0h15 (de julho a agosto) e Escadas das 9h às 23h (de setembro a junho) / 9h às 0h (de julho a agosto)  ",
                        Descricao = "A Torre Eiffel é um dos monumentos mais emblemáticos do mundo. Construída em 1889 para a Exposição Universal, a torre é uma estrutura de ferro forjado com 324 metros de altura. A Torre Eiffel oferece uma vista panorâmica de Paris e é um dos pontos turísticos mais visitados do mundo.   ",
                        Foto = "/imgpaises/imgFranca/Cultura/Torre Eiffel (Paris).png",
                        PaisId = 3,
                         Latitude = -48.8585747744802,
                        Longitude = -2.294438381749423
                },

                new Local() {
                        Id = 105,
                        Nome = "Abadia do Monte Saint-Michel (Mont Saint-Michel)  ",
                        Localizacao = "Place Saint-Michel, 50170 Le Mont-Saint-Michel ",
                        Telefone = "+33 233601414" ,
                        HorarioFuncionamento= "Aberto de Abril a setembro das 9h às 19h (última entrada às 18h), Outubro a março das 9h30 às 18h (última entrada às 17h) e Fechado das 1º de janeiro, 1º de maio e 25 de dezembro ",
                        Descricao = "A Abadia do Monte Saint-Michel é uma abadia beneditina medieval localizada na ilha rochosa de Mont Saint-Michel, na Normandia, França. A abadia foi fundada no século VIII e é um importante local de peregrinação. A abadia é um Patrimônio Mundial da UNESCO e um dos monumentos mais visitados da França.   ",
                        Foto = "/imgpaises/imgFranca/Cultura/Abadia do Monte Saint-Michel(Mont Saint-Michel).png",
                        PaisId = 3,
                         Latitude = -48.63613412235854,
                        Longitude = -1.5117297740794853
                },

                new Local() {
                        Id = 106,
                        Nome = "Museu Picasso (Paris)  ",
                        Localizacao = "Hôtel Salé, 5 Rue de Thorigny, 75003 Paris  ",
                        Telefone = "+33 142721000" ,
                        HorarioFuncionamento= "De Terça a sexta das 10h30 às 18h, Sábado e domingo das 9h30 às 18h e Fechado de Segundas-feiras, 1º de janeiro, 1º de maio e 25 de dezembro ",
                        Descricao = "O Museu Picasso é um museu de arte em Paris, França, dedicado à obra de Pablo Picasso. O museu está situado no Hôtel Salé, uma mansão do século XVII no Marais. A coleção do museu inclui mais de 5.000 obras de Picasso, incluindo pinturas, esculturas, desenhos e gravuras.  ",
                        Foto = "/imgpaises/imgFranca/Cultura/Museu Picasso (Paris).png",
                        PaisId = 3,
                         Latitude = -48.85983918111525,
                        Longitude = -2.3625479796456488
                },

                new Local() {
                        Id = 107,
                        Nome = "Château de Chambord (Vale do Loire)  ",
                        Localizacao = "41250 Chambord  ",
                        Telefone = "+33 254504000" ,
                        HorarioFuncionamento= "Aberto todos os dias das 9h às 18h (última entrada às 17h) e Fechado das 25 de dezembro e 1º de janeiro  ",
                        Descricao = "O Château de Chambord é um dos maiores e mais opulentos castelos do mundo. Foi a residência oficial dos reis da França de 1682 a 1789 e é um símbolo do poder e da riqueza da monarquia francesa. O castelo está situado em uma vasta propriedade que inclui jardins, parques e florestas.  ",
                        Foto = "/imgpaises/imgFranca/Cultura/Château de Chambord (Vale do Loire).png",
                        PaisId = 3,
                         Latitude = -47.6159318200371,
                        Longitude = -1.5168437951725504
                },

                new Local() {
                        Id = 108,
                        Nome = "Museu de Belas Artes de Lyon (Lyon)  ",
                        Localizacao = "20 Place des Terreaux, 69001 Lyon   ",
                        Telefone = "+33 472101740" ,
                        HorarioFuncionamento= "Aberto de Quarta a segunda das 10h às 18h, Sexta das 10h30 às 18h e Fechado de Terças-feiras e feriados  ",
                        Descricao = "O Museu de Belas Artes de Lyon é um dos museus de arte mais importantes da França. Fundado em 1801, o museu possui uma vasta coleção de obras de arte que datam da Antiguidade até o século XXI. A coleção inclui pinturas, esculturas, desenhos, gravuras e artes decorativas.   ",
                        Foto = "/imgpaises/imgFranca/Cultura/Museu de Belas Artes de Lyon (Lyon).png",
                        PaisId = 3,
                         Latitude = -45.767304259530945,
                        Longitude = -4.833586910422204
                },
                #endregion
        #endregion        
        
        #region Inglaterra
                // 109 a 144
                #region IN Natureza
                new Local() {
                        Id = 109,
                        Nome = "Hyde Park - Londres",
                        Localizacao ="Hyde Park, Londres W2 2UH, Reino Unido",
                        Telefone = "+44 20 7298 2000",
                        HorarioFuncionamento= "Todos os dias 24h",
                        Descricao = "Hyde Park é um dos maiores parques do centro de Londres, Inglaterra. É um local popular para caminhadas, piqueniques, passeios de barco e apresentações musicais. O Hyde Park foi criado em 1637 e originalmente era usado como terreno de caça pelo rei Henrique VIII. O parque foi aberto ao público no século XIX e rapidamente se tornou um local popular para os londrinos relaxarem e desfrutarem do ar livre.",
                        Foto = "/imgpaises/img Inglaterra/Natureza/Hyde Park - Londres.png",
                        PaisId=4,
                         Latitude = -51.50768388123743,
                        Longitude = -0.16419937413436145
                },
                new Local() {
                        Id = 110,
                        Nome = "Peak District National Park - Derbyshire",
                        Localizacao ="Peak District National Park Authority, Aldern House, Baslow Road, Bakewell, Derbyshire DE45 1AE, Reino Unido",
                        Telefone = "+44 1726 811911",
                        HorarioFuncionamento= "Todos os dias 24h",
                        Descricao = "O Peak District National Park é um parque nacional no condado de Derbyshire, Inglaterra. Foi criado em 1951 e é o primeiro parque nacional da Inglaterra. O parque cobre uma área de 1.437 quilômetros quadrados e é conhecido por suas paisagens montanhosas, incluindo planaltos calcários, vales e cavernas.",
                        Foto = "/imgpaises/img Inglaterra/Natureza/Peak District National Park - Derbyshire.png",
                        PaisId=4,
                        Latitude = -53.29962121418865,
                        Longitude = -1.8018637039512835
                },
                new Local() {
                        Id = 111,
                        Nome = "Eden Project - Cornwall",
                        Localizacao ="Eden Project, Bodelva, Cornwall PL23 0BP, Reino Unido",
                        Telefone = "+44 1726 811911",
                        HorarioFuncionamento= "Aberto todos os dias das 9h30 às 18h (última entrada às 16h) e Fechado em 24-25 de dezembro",
                        Descricao = "O Eden Project é um jardim botânico e uma atração educacional localizada em Cornwall, Inglaterra. É a maior estufa do mundo e abriga uma vasta coleção de plantas de todo o mundo. O Eden Project está situado em uma antiga mina de argila da China e foi inaugurado em 2001.",
                        Foto = "/imgpaises/img Inglaterra/Natureza/Eden Project - Cornwall.png",
                        PaisId=4,
                        Latitude = -50.360517239437605,
                        Longitude = -4.7447607607623095
                },
                new Local() {
                        Id = 112,
                        Nome = "Chester Zoo - Chester",
                        Localizacao ="Chester Zoo, Upton by Chester, Chester CH2 1LH, Reino Unido",
                        Telefone = "+44 1244 380280",
                        HorarioFuncionamento= "Aberto todos os dias das 10h às 16h (última entrada às 15h)",
                        Descricao = "O Chester Zoo é um jardim zoológico localizado em Chester, Inglaterra. É um dos maiores e mais populares zoológicos do Reino Unido. O zoológico abriga mais de 35.000 animais de mais de 1.200 espécies.",
                        Foto = "/imgpaises/img Inglaterra/Natureza/Chester Zoo - Chester.png",
                        PaisId=4,
                        Latitude = -53.22650887063973,
                        Longitude = -2.882974258565565
                },
                new Local() {
                        Id = 113,
                        Nome = "Lake District National Park - Cumbria",
                        Localizacao ="Brockhole Visitor Centre, Windermere, Cumbria LA23 1LJ, Reino Unido",
                        Telefone = "+44 1539 4 08000",
                        HorarioFuncionamento= "Todos os dias 24h",
                        Descricao = "O Lake District National Park é um parque nacional na Cumbria, Inglaterra. É o maior parque nacional da Inglaterra e é conhecido por suas paisagens montanhosas, incluindo lagos glaciais, montanhas acidentadas e associações literárias históricas.",
                        Foto = "/imgpaises/img Inglaterra/Natureza/Lake District National Park - Cumbria.png",
                        PaisId=4,
                        Latitude = -54.48223080852181,
                        Longitude = -3.0713231790123063
                },
                new Local() {
                        Id = 114,
                        Nome = "The Yorkshire Dales - Yorkshire",
                        Localizacao ="Yorkshire Dales National Park Authority, Yoredale House, 60-62 King Street, Leyburn, North Yorkshire DL8 5DT, Reino Unido",
                        Telefone = "+44 1969 640200",
                        HorarioFuncionamento= "Todos os dias 24h",
                        Descricao = "O Yorkshire Dales National Park é um parque nacional em Yorkshire, Inglaterra. Foi criado em 1954 e é conhecido por suas paisagens montanhosas, incluindo vales calcários, rios e cachoeiras. O Yorkshire Dales National Park cobre uma área de 2.179 quilômetros quadrados e abriga uma variedade de vida selvagem, incluindo ovelhas, vacas e aves de rapina.",
                        Foto = "/imgpaises/img Inglaterra/Natureza/The Yorkshire Dales - Yorkshire.png",
                        PaisId=4,
                        Latitude = -54.2674157328136,
                        Longitude = -2.0850373612648996
                },
                #endregion

                #region IN Compras
                new Local() {
                        Id = 115,
                        Nome = "Westfield London - Londres",
                        Localizacao ="Ariel Way, White City, Londres W12 7GF, Reino Unido",
                        Telefone = "+44 20 3371 2300",
                        HorarioFuncionamento= "De Segunda a sábado das 10h às 22h e de Domingo das 12h às 18h",
                        Descricao = "O Westfield London é um dos maiores centros comerciais da Europa, com mais de 300 lojas, restaurantes e cafés. Localizado em White City, Londres, o centro comercial é um destino popular para compras, alimentação e entretenimento.",
                        Foto = "/imgpaises/img Inglaterra/Compras/Westfield London - Londres.png",
                        PaisId=4,
                        Latitude = -51.50802613358743,
                        Longitude = -0.22111961364599422
                },
                new Local() {
                        Id = 116,
                        Nome = "Bullring - Birmingham",
                        Localizacao ="Bullring & Grand Central, Birmingham B5 4BU, Reino Unido ",
                        Telefone = "+44 121 643 3999",
                        HorarioFuncionamento= "De Segunda a sábado das 10h às 20h e de Domingo das 11h às 17h",
                        Descricao = "O Bullring & Grand Central é um dos maiores centros comerciais do Reino Unido, com mais de 300 lojas, restaurantes e cafés. Localizado em Birmingham, o centro comercial é um destino popular para compras, alimentação e entretenimento.",
                        Foto = "/imgpaises/img Inglaterra/Compras/Bullring - Birmingham.png",
                        PaisId=4,
                        Latitude = -52.477774845046504,
                        Longitude = -1.894371828049406
                },
                new Local() {
                        Id = 117,
                        Nome = "Liverpool ONE - Liverpool",
                        Localizacao ="Liverpool ONE, Liverpool L1 8JQ, Reino Unido  ",
                        Telefone = "+44 151 709 7400 ",
                        HorarioFuncionamento= "De Segunda a sábado das 10h às 20h e de Domingo das 11h às 17h",
                        Descricao = "Liverpool ONE é um centro comercial a céu aberto no centro de Liverpool, Inglaterra. É um destino popular para compras, alimentação e entretenimento, com mais de 170 lojas, restaurantes e bares.",
                        Foto = "/imgpaises/img Inglaterra/Compras/Liverpool ONE - Liverpool.png",
                        PaisId=4,
                        Latitude = -53.404039570225514,
                        Longitude = -2.986988019189587
                },
                new Local() {
                        Id = 118,
                        Nome = "The Lanes - Brighton",
                        Localizacao ="The Lanes, Brighton BN1 1HB, Reino Unido ",
                        Telefone = "+44 151 809 6400",
                        HorarioFuncionamento= "Todos os dias 24h",
                        Descricao = "The Lanes é um labirinto de ruas estreitas e sinuosas com lojas, restaurantes, pubs e cafés peculiares. É um destino popular para compras, alimentação e passeios turísticos. ",
                        Foto = "/imgpaises/img Inglaterra/Compras/The Lanes - Brighton.png",
                        PaisId=4,
                        Latitude = -50.82298147793488,
                        Longitude = -0.1416908676958653
                },
                new Local() {
                        Id = 119,
                        Nome = "Cheshire Oaks Designer Outlet - Ellesmere Port",
                        Localizacao ="Cheshire Oaks Designer Outlet, Ellesmere Port, Cheshire CH65 9JJ, Reino Unido ",
                        Telefone = "+44 151 356 5000",
                        HorarioFuncionamento= "De Segunda a sábado das 10h às 20h e de Domingo das 10h às 18h ",
                        Descricao = "O Cheshire Oaks Designer Outlet é o maior outlet do Reino Unido, com mais de 145 lojas de grife. Localizado em Ellesmere Port, Cheshire, o outlet é um destino popular para compras com descontos de até 60%.",
                        Foto = "/imgpaises/img Inglaterra/Compras/Cheshire Oaks Designer Outlet - Ellesmere Port.png",
                        PaisId=4,
                        Latitude = -53.26579018404187,
                        Longitude = -2.8814931346667803
                },
                new Local() {
                        Id = 120,
                        Nome = "Cabot Circus - Bristo",
                        Localizacao ="Cabot Circus, Bristol BS1 3BH, Reino Unido ",
                        Telefone = "+44 117 929 4400",
                        HorarioFuncionamento= "De Segunda a sábado das 9h30 às 20h e de Domingo das 11h às 17h ",
                        Descricao = "O Cabot Circus é um centro comercial coberto em Bristol, Inglaterra. É adjacente a Broadmead, um bairro comercial no centro da cidade de Bristol. A área de desenvolvimento do Cabot Circus contém lojas, escritórios, um hotel, 250 apartamentos e antigamente um cinema. ",
                        Foto = "/imgpaises/img Inglaterra/Compras/Cabot Circus - Bristol.png",
                        PaisId=4,
                        Latitude = -51.459029140747006,
                        Longitude = -2.5852566136931094
                },
                #endregion

                #region IN Vida Noturna
                new Local() {
                        Id = 121,
                        Nome = "Fabric - Londres",
                        Localizacao ="77 Charterhouse Street, Farringdon, Londres EC1M 6HJ, Reino Unido",
                        Telefone = "+44 20 7336 8898 ",
                        HorarioFuncionamento= "De Sexta-feira das 23h às 6h e de Sábado das 23h às 6h ",
                        Descricao = "O Fabric é uma boate noturna em Londres, Inglaterra, conhecida por sua música eletrônica underground. Fundado em 1999, o clube já foi eleito o melhor clube do mundo pela revista DJ Magazine em várias ocasiões. ",
                        Foto = "/imgpaises/img Inglaterra/VidaNoturna/Fabric - Londres.png",
                        PaisId=4,
                        Latitude = -51.52003421394557,
                        Longitude = -0.10261289033996089
                },
                new Local() {
                        Id = 122,
                        Nome = "The Cavern Club - Liverpool",
                        Localizacao ="10 Mathew Street, Liverpool L2 7NA, Reino Unido",
                        Telefone = "+44 151 236 9091 ",
                        HorarioFuncionamento= "De Segunda a sábado das 10h às 23h e de Domingo das 12h às 22h ",
                        Descricao = "O Cavern Club é um clube de música ao vivo em Liverpool, Inglaterra, famoso por ser o local onde os Beatles tocaram pela primeira vez em 1961. O clube é um marco histórico e um destino popular para turistas de todo o mundo. ",
                        Foto = "/imgpaises/img Inglaterra/VidaNoturna/The Cavern Club - Liverpool.png",
                        PaisId=4,
                         Latitude = -53.66608218144352,
                        Longitude = -3.0877024993674143
                },
                new Local() {
                        Id = 123,
                        Nome = "The Haunt - Brighton",
                        Localizacao ="The Haunt, 13-14 North Road, Brighton BN1 1YD, Reino Unido ",
                        Telefone = "+44 1273 606 999",
                        HorarioFuncionamento= "De Segunda a sábado das 11h às 23h e de  Domingo das 12h às 22h ",
                        Descricao = "The Haunt é um pub e local de música ao vivo em Brighton, Inglaterra. É conhecido por sua música alternativa e indie, e já recebeu shows de bandas como The Smiths, The Cure e Radiohead. O Haunt possui duas salas: a sala principal e a sala Basement. A sala principal é a maior sala e é onde se apresentam as bandas principais. A sala Basement é uma sala menor que apresenta bandas novas e emergentes. ",
                        Foto = "/imgpaises/img Inglaterra/VidaNoturna/The Haunt - Brighton.png",
                        PaisId=4,
                         Latitude = -50.82080816855798,
                        Longitude = -0.13912651345095
                },
                new Local() {
                        Id = 124,
                        Nome = "The Warehouse Project - Manchester",
                        Localizacao ="Store Street, Manchester M1 2WD, Reino Unido ",
                        Telefone = "+44 161 236 9091",
                        HorarioFuncionamento= "Varia de acordo com o evento ",
                        Descricao = "O Warehouse Project (WHP) é um dos clubes mais famosos do Reino Unido, conhecido por sua programação de DJs internacionais de música eletrônica underground. O clube fica em Manchester, Inglaterra, e funciona em um antigo armazém convertido, o que contribui para sua atmosfera única. ",
                        Foto = "/imgpaises/img Inglaterra/VidaNoturna/The Warehouse Project - Manchester.png",
                        PaisId=4,
                         Latitude = -53.47599643937941,
                        Longitude = -2.225467388436286
                },
                new Local() {
                        Id = 125,
                        Nome = "Thekla - Bristol",
                        Localizacao ="Thekla, Mud Dock, The Grove, Bristol BS1 4RB, Reino Unido ",
                        Telefone = "+44 117 929 4400",
                        HorarioFuncionamento= "Varia de acordo com o evento ",
                        Descricao = "O Thekla é um barco-clube noturno e local de música ao vivo em Bristol, Inglaterra. É um barco de carga convertido que está ancorado no porto de Bristol. O Thekla é conhecido por sua programação eclética de música ao vivo, que inclui bandas indie, DJs de música eletrônica e apresentações de comédia. ",
                        Foto = "/imgpaises/img Inglaterra/VidaNoturna/Thekla - Bristol.png",
                        PaisId=4,
                         Latitude = -51.44938942685273,
                        Longitude = -2.5940763290433217
                },
                new Local() {
                        Id = 126,
                        Nome = "O2 Academy - Birmingham",
                        Localizacao ="O2 Academy Birmingham, 152-154 Broad Street, Birmingham B1 2HT, Reino Unido ",
                        Telefone = "+44 121 644 4444",
                        HorarioFuncionamento= "Varia de acordo com o evento ",
                        Descricao = "A O2 Academy Birmingham é uma casa de shows em Birmingham, Inglaterra, com capacidade para 3.000 pessoas. É conhecida por sua programação de shows de música ao vivo, que inclui artistas internacionais e nacionais de diversos gêneros musicais. ",
                        Foto = "/imgpaises/img Inglaterra/VidaNoturna/O2 Academy - Birmingham.png",
                        PaisId=4,
                         Latitude = -51.53127730827401,
                        Longitude = -2.5912643961407835
                },
                #endregion

                #region IN Espiritualidade 
                new Local() {
                        Id = 127,
                        Nome = "Catedral de Canterbury - Canterbury",
                        Localizacao ="11 The Precincts, Canterbury CT1 2EH, Reino Unido ",
                        Telefone = "+44 1227 762 862 ",
                        HorarioFuncionamento= "De Segunda a sexta das 9h30 às 17h30, Sábado das 9h30 às 15h30 e de Domingo é Fechado ",
                        Descricao = "A Catedral de Canterbury é uma catedral gótica em Canterbury, Inglaterra. É a sede do Arcebispo de Canterbury, o líder espiritual da Igreja da Inglaterra. A catedral foi fundada em 597 d.C. e é um Patrimônio Mundial da UNESCO. ",
                        Foto = "/imgpaises/img Inglaterra/Fe/Catedral de Canterbury (Cantebury).png",
                        PaisId=4,
                        Latitude = -51.280414063213094,
                        Longitude = -1.0829285014767407
                },
                new Local() {
                        Id = 128,
                        Nome = "Catedral de York Minster - York",
                        Localizacao ="Deangate, York YO1 7HH, Reino Unido ",
                        Telefone = "+44 1904 624 429 ",
                        HorarioFuncionamento= "De Segunda a sábado das 9h30 às 17h30 (última entrada às 16h45) e de Domingo é Fechado ",
                        Descricao = "A Catedral de York Minster é uma catedral gótica em York, Inglaterra. É a sede do Arcebispo de York, o segundo líder espiritual mais importante da Igreja da Inglaterra. A catedral foi fundada em 627 d.C. e é um Patrimônio Mundial da UNESCO. A Catedral de York Minster é uma das maiores catedrais góticas da Europa. É um local de peregrinação há séculos e é um dos destinos turísticos mais populares do país. ",
                        Foto = "/imgpaises/img Inglaterra/Fe/Catedral de York Minster - York.png",
                        PaisId=4,
                        Latitude = -53.962757970452664,
                        Longitude = -1.0821780339784322
                },
                new Local() {
                        Id = 129,
                        Nome = "Catedral de Durham - Durham",
                        Localizacao ="The Cathedral, College Green, Durham DH1 3EH, Reino Unido ",
                        Telefone = "+44 191 338 3111",
                        HorarioFuncionamento= "De Segunda a sexta das 10h às 17h (última entrada às 16h30), Sábado das 9h30 às 17h (última entrada às 16h30) e de Domingo das 12h30 às 14h30 (última entrada às 14h) ",
                        Descricao = "A Catedral de Durham é uma catedral normanda em Durham, Inglaterra. É a sede do Bispo de Durham e um Patrimônio Mundial da UNESCO. A catedral foi fundada em 1093 e é considerada um dos melhores exemplos da arquitetura normanda na Europa. ",
                        Foto = "/imgpaises/img Inglaterra/Fe/Catedral de Durham - Durham.png",
                        PaisId=4,
                        Latitude = -54.77387606712855,
                        Longitude = -1.57600590305344
                },
                new Local() {
                        Id = 130,
                        Nome = "Catedral de Salisbury - Salisbury",
                        Localizacao ="6 The Close, Salisbury SP1 2EL, Reino Unido ",
                        Telefone = "+44 1722 555 123 ",
                        HorarioFuncionamento= "De Segunda a sábado das 10h às 17h (última entrada às 16h) e de Domingo é Fechado ",
                        Descricao = "A Catedral de Salisbury é uma catedral gótica em Salisbury, Inglaterra. É conhecida por sua torre de 123 metros de altura, a mais alta do Reino Unido, e por sua bela arquitetura gótica. A catedral foi fundada em 1220 e é considerada um dos melhores exemplos da arquitetura gótica inglesa. ",
                        Foto = "/imgpaises/img Inglaterra/Fe/Catedral de Salisbury - Salisbury.png",
                        PaisId=4,
                        Latitude = -51.065579976062445,
                        Longitude = -1.7974322907751776
                },
                new Local() {
                        Id = 131,
                        Nome = "Catedral de St. Paul - Londres",
                        Localizacao ="t. Paul's Churchyard, London EC4M 8AD, Reino Unido",
                        Telefone = "+44 20 7236 4128 ",
                        HorarioFuncionamento= "De Segunda a sábado das 8h30 às 16h30 (última entrada às 16h) e fechado de Domingo ",
                        Descricao = "A Catedral de St. Paul é uma catedral anglicana em Londres, Inglaterra. É a sede do Bispo de Londres e uma das maiores igrejas do Reino Unido. A catedral foi projetada por Sir Christopher Wren e construída entre 1675 e 1710. A Catedral de St. Paul é um dos edifícios mais emblemáticos de Londres. É um local de grande importância histórica e religiosa, e é um dos destinos turísticos mais populares da cidade.",
                        Foto = "/imgpaises/img Inglaterra/Fe/Catedral de St. Paul - Londres.png",
                        PaisId=4,
                        Latitude = -51.51451252696512,
                        Longitude = -0.09830772898106742
                },
                new Local() {
                        Id = 132,
                        Nome = "Catedral de Winchester - Winchester",
                        Localizacao ="1 The Close, Winchester SO23 9LS, Reino Unido ",
                        Telefone = "+44 1962 854 225 ",
                        HorarioFuncionamento= "De Segunda a sábado das 10h às 17h30 (última entrada às 16h45) e de Domingo é Fechado ",
                        Descricao = "A Catedral de Winchester é uma catedral gótica em Winchester, Inglaterra. É a maior catedral gótica da Europa em termos de área e é um Patrimônio Mundial da UNESCO. A catedral foi fundada em 1079 e é considerada um dos melhores exemplos da arquitetura gótica inglesa. ",
                        Foto = "/imgpaises/img Inglaterra/Fe/Catedral de Winchester - Winchester.png",
                        PaisId=4,
                        Latitude = -51.06147093344404,
                        Longitude = -1.313368421461494
                },
                #endregion

                #region IN Restaurantes
                new Local() {
                        Id = 133,
                        Nome = "The Sportsman, Seasalter",
                        Localizacao ="Faversham Road, Seasalter, Whitstable CT5 4BP, Reino Unido ",
                        Telefone = "+44 1227 273 370 ",
                        HorarioFuncionamento= "De Terça a sábado das 12h às 14h30 e depois das18h30 às 21h30 e de Domingo das 12h às 14h30 e fechado de segunda ",
                        Descricao = "The Sportsman é um pub gastronômico premiado com uma estrela Michelin, situado na vila costeira de Seasalter, em Kent, Inglaterra. É conhecido por sua culinária inovadora e sazonal, que destaca os melhores ingredientes locais. ",
                        Foto = "/imgpaises/img Inglaterra/Restaurantes/The Sportsman, Seasalter.png",
                        PaisId=4,
                        Latitude = -51.34432244898336,
                        Longitude = -0.9589331708559281
                },
                new Local() {
                        Id = 134,
                        Nome = "Sketch - Londres",
                        Localizacao ="9 Conduit Street, Mayfair, Londres W1S 2XG, Reino Unido ",
                        Telefone = "+44 20 7659 8585 ",
                        HorarioFuncionamento= "De Segunda a sexta das 12h às 23h30, Sábado das 11h às 23h30 e de Domingo é Fechado ",
                        Descricao = "O Sketch é um restaurante e bar requintado em Londres, famoso por seu interior luxuoso e sua cozinha inovadora. O restaurante é dividido em vários espaços distintos, cada um com seu próprio tema e atmosfera. ",
                        Foto = "/imgpaises/img Inglaterra/Restaurantes/Sketch - Londres.png",
                        PaisId=4,
                        Latitude = -51.51319999798596,
                        Longitude = -0.14144321364106205
                },
                new Local() {
                        Id = 135,
                        Nome = "Gordon Ramsay Bar & Grill - Edimburgo",
                        Localizacao ="50 Queen Street, Edinburgh EH2 3NH, Reino Unido ",
                        Telefone = "+44 131 220 0292 ",
                        HorarioFuncionamento= "De Segunda a sexta das 12h às 14h30 e depois das 17h30 às 22h30, Sábado das12h às 22h30 e de Domingo é Fechado ",
                        Descricao = "O Gordon Ramsay Bar & Grill é um restaurante elegante e contemporâneo em Edimburgo, com vista para o Castelo de Edimburgo. O restaurante é conhecido por sua cozinha clássica com um toque moderno e por seu serviço impecável. ",
                        Foto = "/imgpaises/img Inglaterra/Restaurantes/Gordon Ramsay Bar & Grill - Edimburgo.png",
                        PaisId=4,
                        Latitude = -51.515654432669805,
                        Longitude = -0.1511448122342247
                },
                new Local() {
                        Id = 136,
                        Nome = "The Ivy - Manchester",
                        Localizacao ="The Midland Hotel, 1 Peter Street, Manchester M2 1NQ, Reino Unido ",
                        Telefone = "+44 161 235 4444 ",
                        HorarioFuncionamento= "DeSegunda a sexta das 12h às 14h30 e depois das 17h30 às 22h30, Sábado das 12h às 22h30 e Domingo é Fechado ",
                        Descricao = "O The Ivy Manchester é um restaurante elegante e luxuoso em Manchester, situado no histórico Midland Hotel. O restaurante é conhecido por sua cozinha clássica britânica com um toque moderno e por seu ambiente sofisticado. ",
                        Foto = "/imgpaises/img Inglaterra/Restaurantes/The Ivy - Manchester.png",
                        PaisId=4,
                        Latitude = -51.520937652903115,
                        Longitude = -0.1638478986090502
                },
                new Local() {
                        Id = 137,
                        Nome = "The Waterside Inn - Bray, Berkshire",
                        Localizacao ="Waterside Inn, Ferry Road, Bray, Berkshire SL6 2AT, Reino Unido ",
                        Telefone = "+44 1628 620 691",
                        HorarioFuncionamento= "Almoço de Segunda a sexta, das 12h30 às 14h, Jantar de Segunda a sábado, das 19h às 21h30 e Fechado de Domingos e feriados ",
                        Descricao = "O Waterside Inn é um restaurante com três estrelas Michelin em Bray, Berkshire, Inglaterra. É conhecido por sua culinária clássica francesa com um toque moderno e por seu ambiente elegante e sofisticado. O restaurante é comandado pelo chef Alain Roux, que assumiu o comando do restaurante de seu pai, Michel Roux, em 1992. Alain Roux manteve a tradição de excelência do restaurante, e o Waterside Inn continua a ser um dos restaurantes mais aclamados do mundo. ",
                        Foto = "/imgpaises/img Inglaterra/Restaurantes/The Waterside Inn - Bray, Berkshire.png",
                        PaisId=4,
                        Latitude = -51.50947410902787,
                        Longitude = -0.6998825363733905
                },
                new Local() {
                        Id = 138,
                        Nome = "The Ledbury - Londres",
                        Localizacao ="127 Ledbury Road, Notting Hill, Londres W11 2AQ, Reino Unido ",
                        Telefone = "+44 20 7792 9090 ",
                        HorarioFuncionamento= "Fechado de Terça-feira e Quarta-feira, Almoço de Quinta a Segunda, das 12h30 às 14h e Jantar de Quinta a Segunda, das 19h às 21h30",
                        Descricao = "O Ledbury é um restaurante com duas estrelas Michelin em Notting Hill, Londres, Inglaterra. É conhecido por sua culinária moderna europeia com foco em ingredientes sazonais e de alta qualidade. O restaurante é comandado pelo chef Brett Graham, que assumiu o comando em 2011. Graham manteve a tradição de excelência do restaurante, e o Ledbury continua a ser um dos restaurantes mais aclamados de Londres. ",
                        Foto = "/imgpaises/img Inglaterra/Restaurantes/The Ledbury - Londres.png",
                        PaisId=4,
                        Latitude = -51.51713524848876,
                        Longitude = -0.20014887500168768
                },
                #endregion

                #region IN Cultura
                new Local() {
                        Id = 139,
                        Nome = "Museu Britânico - Londres",
                        Localizacao ="Great Russell Street, Londres WC1B 3DG, Reino Unido ",
                        Telefone = "+44 20 7323 8299 ",
                        HorarioFuncionamento= "Aberto diariamente das 10h às 17h30, Fechado das 24, 25 e 26 de dezembro e 1º de janeiro ",
                        Descricao = "O Museu Britânico é um dos maiores e mais importantes museus do mundo. Ele abriga uma vasta coleção de artefatos da história e da cultura humana, desde a pré-história até o presente. O museu foi fundado em 1753 e está situado em Bloomsbury, Londres. O edifício principal do museu é uma estrutura imponente em estilo neoclássico. ",
                        Foto = "/imgpaises/img Inglaterra/Cultura/Museu Britânico - Londres.png",
                        PaisId=4,
                        Latitude = -51.520053741705155,
                        Longitude = -0.12687081363462369
                },
                new Local() {
                        Id = 140,
                        Nome = "Palacio de Buckingham - Londres",
                        Localizacao ="Buckingham Palace, London SW1A 1AA, Reino Unido",
                        Telefone = "+44 20 7323 1234",
                        HorarioFuncionamento= "Aberto todos os dias 24h",
                        Descricao = "O Palácio de Buckingham é a residência oficial do monarca do Reino Unido em Londres. É um dos maiores e mais luxuosos palácios do mundo. O palácio foi construído em 1703 e foi originalmente a casa do Duque de Buckingham. Em 1762, o rei George III o adquiriu para a Coroa Britânica. ",
                        Foto = "/imgpaises/img Inglaterra/Cultura/Palacio de Buckingham - Londres.png",
                        PaisId=4,
                        Latitude = -51.501817695437175,
                        Longitude = -0.14163255228754965
                },
                new Local() {
                        Id = 141,
                        Nome = "Castelo de Windsor - Windsor",
                        Localizacao ="Windsor Castle, Windsor SL4 1NJ, Reino Unido ",
                        Telefone = "+44 300 123 7300",
                        HorarioFuncionamento= "Aberto ao público em 22 de julho a 2 de outubro de 2023, de Segunda a sábado das 10h às 17h15 (última entrada às 16h15) e de Domingo das 12h15 às 17h15 (última entrada às 16h15) ",
                        Descricao = "O Castelo de Windsor é a maior e mais antiga fortaleza habitada do mundo. É a residência oficial da Rainha Elizabeth II no Reino Unido. O castelo foi fundado por Guilherme, o Conquistador, no século XI. Ao longo dos séculos, o castelo foi ampliado e reformado por vários monarcas ingleses. ",
                        Foto = "/imgpaises/img Inglaterra/Cultura/Castelo de Windsor - Windsor.png",
                        PaisId=4,
                        Latitude = -51.484775461096895,
                        Longitude = -0.6047031517386197
                },
                new Local() {
                        Id = 142,
                        Nome = "Banhos Romanos - Bath",
                        Localizacao ="Roman Baths, Stall Street, Bath BA1 1LZ, Reino Unido ",
                        Telefone = "+44 1225 477 777 ",
                        HorarioFuncionamento= "Aberto diariamente das 9h às 17h (última entrada às 16h) e Fechado em 24, 25 e 26 de dezembro ",
                        Descricao = "Os Banhos Romanos são um complexo de ruínas romanas bem preservadas em Bath, Inglaterra. Eles foram construídos no século I d.C. e eram um importante centro social e religioso para os romanos. Os banhos são compostos por uma série de piscinas, salas de vapor e saunas. As piscinas eram aquecidas por um sistema de hipocausto, que usava o calor do fogo subterrâneo.",
                        Foto = "/imgpaises/img Inglaterra/Cultura/Banhos Romanos - Bath.png",
                        PaisId=4,
                        Latitude = -51.382137297061554,
                        Longitude = -2.365456493335392
                },
                new Local() {
                        Id = 143,
                        Nome = "Museu da Liverpool World Museum - Liverpool",
                        Localizacao ="World Museum, William Brown Street, Liverpool L3 8EN, Reino Unido ",
                        Telefone = "+44 151 478 4393 ",
                        HorarioFuncionamento= "Aberto diariamente das 10h às 17h e Fechado em 24, 25 e 26 de dezembro ",
                        Descricao = "O Museu Mundial de Liverpool é um dos maiores museus nacionais do Reino Unido. Ele abriga uma vasta coleção de artefatos da história e da cultura humana, desde a pré-história até o presente. O museu foi fundado em 1851 e está situado no centro de Liverpool. O edifício principal do museu é uma estrutura imponente em estilo neoclássico. ",
                        Foto = "/imgpaises/img Inglaterra/Cultura/Museu da Liverpool World Museum - Liverpool.png",
                        PaisId=4,
                        Latitude = -53.406785826577334,
                        Longitude = -2.9876937727547936
                },
                new Local() {
                        Id = 144,
                        Nome = "Museu de História de Manchester - Manchester",
                        Localizacao ="55 Mosley Street, Manchester M2 3JL, Reino Unido ",
                        Telefone = "+44 161 838 9120 ",
                        HorarioFuncionamento= "De Terça a sábado das 10h às 17h, Domingo das 12h às 17h e Fechado em 24, 25 e 26 de dezembro ",
                        Descricao = "O Museu de História de Manchester é um museu que narra a história da cidade e da região, desde a pré-história até os dias atuais. Ele abriga uma vasta coleção de artefatos, incluindo roupas, ferramentas, armas, documentos e fotografias. ",
                        Foto = "/imgpaises/img Inglaterra/Cultura/Museu de História de Manchester - Manchester.png",
                        PaisId=4,
                        Latitude = -53.4668769105683,
                        Longitude = -2.23442360378653
                },
                #endregion
        #endregion
        
        #region Italia 
                // 145 a 180
                #region IT Natureza
                        new Local () {
                        Id = 145,
                        Nome = "Parco Nazionale Gran Paradiso (Alpes)",
                        Localizacao = "Parco Nazionale Gran Paradiso Cogne, 11012 AO",
                        Telefone = "+39 0165 740 011",
                        HorarioFuncionamento = "Todos os dias 24h",
                        Descricao = "O Parque Nacional Gran Paradiso é o parque nacional mais antigo da Itália, fundado em 1922. Localiza-se no Vale de Aosta e no Piemonte, em torno do maciço do Gran Paradiso. O parque abriga uma grande variedade de flora e fauna, incluindo o íbex, o camurça, a marmota e a águia real.",
                        Foto = "/imgpaises/img Itália/Natureza/Parco Nazionale Gran Paradiso - Alpes.png",
                        PaisId = 4,
                        Latitude = -45.52217791083705,
                        Longitude = -7.32453744110275
                        },

                        new Local () {
                        Id = 146,
                        Nome = "Villa Borghese Gardens (Roma)",
                        Localizacao = "Piazzale Napoleone I, 00197 Roma RM",
                        Telefone = "+39 06 32 810",
                        HorarioFuncionamento = "Todos os dias 24h",
                        Descricao = "Os Jardins Villa Borghese são um dos maiores parques públicos de Roma, com uma área de 800.000 metros quadrados. O parque foi criado no século XVII pelo cardeal Scipione Borghese e posteriormente doado à cidade de Roma em 1903.",
                        Foto = "/imgpaises/img Itália/Natureza/Villa Borghese Gardens - Roma.png",
                        PaisId = 4,
                         Latitude = -41.91406179977368,
                        Longitude = -12.485338881394522
                        },

                        new Local () {
                        Id = 147,
                        Nome = "Parco Nazionale delle Cinque Terre (Ligúria)",
                        Localizacao = "Parco Nazionale delle Cinque Terre Via Aldo Romano, 16 19018 La Spezia SP",
                        Telefone = "+39 0187 730 274",
                        HorarioFuncionamento = "De segunda a sexta-feira, das 9h às 13h e das 14h às 17h",
                        Descricao = "O Parque Nacional Cinque Terre é um parque nacional italiano que se estende ao longo da costa da Ligúria, entre as cidades de La Spezia e Levanto. O parque é composto por cinco vilas: Riomaggiore, Manarola, Corniglia, Vernazza e Monterosso al Mare. As Cinque Terre são famosas por suas casas coloridas, que se agarram às encostas íngremes dos penhascos.",
                        Foto = "/imgpaises/img Itália/Natureza/Parco Nazionale delle Cinque Terre - Ligúria.png",
                        PaisId = 4,
                        Latitude = -44.12822448590502,
                        Longitude = -9.71244434103227
                        },

                        new Local () {
                        Id = 148,
                        Nome = "Zoo Safari Fasano (Puglia)",
                        Localizacao = "Strada Provinciale per Fasano, 72, 72015 Fasano BR",
                        Telefone = "+39 080 441 4777",
                        HorarioFuncionamento = "Aberto todos os dias das 9h até as 18h",
                        Descricao = "O Zoológico Safari Fasano é um zoológico e parque de diversões localizado em Fasano, na região de Puglia, na Itália. O zoológico abriga mais de 2.000 animais de 200 espécies diferentes, incluindo leões, tigres, elefantes, girafas e zebras. O parque de diversões tem várias atrações, como montanhas-russas, carrosséis e um parque aquático.",
                        Foto = "/imgpaises/img Itália/Natureza/Zoo Safari Fasano - Puglia.png",
                        PaisId = 4,
                        Latitude = -40.83260550757396,
                        Longitude = -17.340702823670295
                        },

                        new Local () {
                        Id = 149,
                        Nome = "Parco Nazionale d'Abruzzo (Lazio e Molise)",
                        Localizacao = "Parco Nazionale d'Abruzzo, Lazio e Molise Viale A. Gramsci, 300 67032 Pescasseroli AQ",
                        Telefone = "+39 0862 879 111",
                        HorarioFuncionamento = "Segunda a sexta, das 9h às 13h e das 14h às 17h",
                        Descricao = "O Parco Nazionale d'Abruzzo, Lazio e Molise é um parque nacional italiano que se estende pelas regiões de Abruzzo, Lazio e Molise. O parque foi criado em 1922 e é um dos mais antigos parques nacionais da Itália. O parque abriga uma grande variedade de flora e fauna, incluindo lobos, ursos marrons, linces e águias reais.",
                        Foto = "/imgpaises/img Itália/Natureza/Parco Nazionale d'Abruzzo, Lazio e Molise.png",
                        PaisId = 4,
                         Latitude = -41.80901479266633,
                        Longitude = -13.790006594879545
                        },

                        new Local () {
                        Id = 150,
                        Nome = "Parco del Valentino (Turim)",
                        Localizacao = "Corso Massimo d'Azeglio, Turim",
                        Telefone = "+39 011 011 2550",
                        HorarioFuncionamento = "Todos os dias 24h",
                        Descricao = "O Parco del Valentino é um parque público de 42 hectares situado na margem esquerda do Rio Pó, em Turim, Itália. O parque foi criado em 1856 e é um dos maiores parques urbanos da Europa.",
                        Foto = "/imgpaises/img Itália/Natureza/Parco del Valentino - Turim.png",
                        PaisId = 4,
                         Latitude = -45.05496813761726,
                        Longitude = -7.686607350856017
                        },
                #endregion

                #region IT Compras
                        new Local () {
                        Id = 151,
                        Nome = "Galleria Vittorio Emanuele II (Milão)",
                        Localizacao = "Piazza del Duomo, 2, 20121 Milano MI",
                        Telefone = "+39 02 869 021",
                        HorarioFuncionamento = "Todos os dias 24h",
                        Descricao = "A Galleria Vittorio Emanuele II é um centro comercial de luxo em Milão, Itália. Foi projetada por Giuseppe Mengoni e inaugurada em 1867. A galeria é considerada um dos marcos mais importantes de Milão e um dos mais belos centros comerciais do mundo.",
                        Foto = "/imgpaises/img Itália/Compras/Galleria Vittorio Emanuele II - Milão.png",
                        PaisId = 4,
                        Latitude = -45.465832982070765,
                        Longitude = -9.190062154589953
                        },

                        new Local () {
                        Id = 152,
                        Nome = "Via del Corso (Roma)",
                        Localizacao = "Via del Corso, 00187 Roma RM",
                        Telefone = "+39 06 6710 9444",
                        HorarioFuncionamento = "Todos os dias 24h",
                        Descricao = "A Via del Corso é uma das principais ruas comerciais de Roma, Itália. Ela se estende desde a Piazza del Popolo até a Piazza Venezia e é ladeada por lojas de todos os tipos, desde lojas de grife internacionais até lojas de souvenirs. A rua também é conhecida por seus cafés e restaurantes.",
                        Foto = "/imgpaises/img Itália/Compras/Via del Corso - Roma.png",
                        PaisId = 4,
                        Latitude = -42.04033379276038,
                        Longitude = -12.43736668445231
                        },

                        new Local () {
                        Id = 153,
                        Nome = "Designer Outlet Valdichiana Village (Arezzo)",
                        Localizacao = "Via S. Margherita, 5, 52041 Foiano della Chiana AR",
                        Telefone = "+39 0575 401 200",
                        HorarioFuncionamento = "De Segunda a domingo das 10h às 20h Fechado na Páscoa e Aberto de Segunda de Páscoa das10h às 20h",
                        Descricao = "O Designer Outlet Valdichiana Village é um outlet de grife localizado em Foiano della Chiana, na Toscana, Itália. O outlet abriga mais de 140 lojas de marcas famosas, como Gucci, Prada e Versace, com descontos de até 70%. O outlet também oferece uma variedade de restaurantes e cafés, um playground e um serviço de Wi-Fi gratuito.",
                        Foto = "/imgpaises/img Itália/Compras/Designer Outlet Valdichiana Village - Arezzo.png",
                        PaisId = 4,
                        Latitude = -43.22547214344767,
                        Longitude = -11.801671323784579
                        },


                        new Local () {
                        Id = 154,
                        Nome = "La Rinascente (Florença)",
                        Localizacao = "Piazza della Repubblica, 2, 50123 Firenze FI",
                        Telefone = "+39 055 276 81",
                        HorarioFuncionamento = "De Segunda a sábado das 9h30 às 20h, Domingo das 10h às 20h e Fechado em 25 de dezembro e 1º de janeiro",
                        Descricao = "La Rinascente é uma loja de departamentos de luxo localizada na Piazza della Repubblica, em Florença, Itália. A loja foi fundada em 1865 e é uma das lojas de departamentos mais antigas da Itália. La Rinascente oferece uma ampla variedade de produtos, incluindo roupas, acessórios, cosméticos, artigos para casa e eletrônicos. A loja também possui um restaurante e um café.",
                        Foto = "/imgpaises/img Itália/Compras/La Rinascente - Florença.png",
                        PaisId = 4,
                        Latitude = -43.771456681396316,
                        Longitude = -11.254698198687759
                        },

                        new Local () {
                        Id = 155,
                        Nome = "The Mall (Leccio)",
                        Localizacao = "Via Europa, 8, 50065 Leccio FI",
                        Telefone = "+39 055 865 7775",
                        HorarioFuncionamento = "De Segunda a sábado das 10h às 19h, Domingo das 10h às 19h e Fechado em 25 de dezembro e 1º de janeiro",
                        Descricao = "O The Mall é um outlet de luxo localizado em Leccio, na Toscana, Itália. O outlet abriga mais de 80 lojas de marcas famosas, como Gucci, Prada e Versace, com descontos de até 70%. O outlet também oferece uma variedade de restaurantes e cafés, um playground e um serviço de Wi-Fi gratuito.",
                        Foto = "/imgpaises/img Itália/Compras/The Mall- Leccio.png",
                        PaisId = 4,
                        Latitude = -43.70230283939619,
                        Longitude = -11.464037914196865
                        },

                        new Local () {
                        Id = 156,
                        Nome = "Centro Commerciale Porta di Roma (Roma)",
                        Localizacao = "Via del Ponte di Piscina Cupa, 64, 00154 Roma RM",
                        Telefone = "+39 06 551 7292",
                        HorarioFuncionamento = "De Segunda a sábado das 9h às 21h, Domingo das 9h às 20h e Fechado em 25 de dezembro e 1º de janeiro",
                        Descricao = "O Centro Commerciale Porta di Roma é um shopping center localizado em Roma, Itália. É o maior shopping center da Europa, com mais de 220 lojas, incluindo lojas de grife, lojas de departamento, restaurantes e cafés. O shopping center também possui um cinema, um parque de diversões e um parque aquático.",
                        Foto = "/imgpaises/img Itália/Compras/Centro Commerciale Porta di Roma - Roma.png",
                        PaisId = 4,
                        Latitude = -41.9718437866932,
                        Longitude = -12.540170294887336
                        },
                #endregion

                #region IT Vida Noturna
                        new Local () {
                        Id = 157,
                        Nome = "Armani Privé (Milão)",
                        Localizacao = "Via del Ponte di Piscina Cupa, 64, 00154 Roma RM",
                        Telefone = "+39 06 551 7292",
                        HorarioFuncionamento = "De Segunda a sábado das 9h às 21h, Domingo das 9h às 20h e Fechado em 25 de dezembro e 1º de janeiro",
                        Descricao = "O Centro Commerciale Porta di Roma é um shopping center localizado em Roma, Itália. É o maior shopping center da Europa, com mais de 220 lojas, incluindo lojas de grife, lojas de departamento, restaurantes e cafés. O shopping center também possui um cinema, um parque de diversões e um parque aquático.",
                        Foto = "/imgpaises/img Itália/VidaNoturna/Armani Privé - Milão.png",
                        PaisId = 4,
                        Latitude = -45.4660708124777,
                        Longitude = -9.189994978333953
                        },

                        new Local () {
                        Id = 158,
                        Nome = "Campo de' Fiori (área com vários bares) (Roma)",
                        Localizacao = "Piazza Campo de' Fiori, 00186 Roma RM, Itália",
                        Telefone = "+39 06 6710 9444",
                        HorarioFuncionamento = "Todos os dias 24h",
                        Descricao = "O Campo de' Fiori é uma praça histórica localizada no centro de Roma, Itália. A praça é conhecida por seu mercado de flores, que funciona de segunda a sábado, das 7h às 13h. A praça também é conhecida por seus bares e restaurantes, que oferecem uma variedade de comidas e bebidas.",
                        Foto = "/imgpaises/img Itália/VidaNoturna/Campo de' Fiori (área com vários bares) - Roma.png",
                        PaisId = 4,
                        Latitude = -45.46574268809008,
                        Longitude = -9.189997781126635
                        },

                        new Local () {
                        Id = 159,
                        Nome = "Yab Discoteca (Florença)",
                        Localizacao = "TVia de' Pecori, 32r, 50123 Firenze FI, Itália",
                        Telefone = "+39 392 494 9852",
                        HorarioFuncionamento = "Sexta-feira das 23h às 4h e Sábado das 23h às 4h",
                        Descricao = "Yab Discoteca é uma boate moderna e elegante localizada no centro de Florença, Itália. A boate oferece uma variedade de música, desde música pop até música eletrônica. Yab Discoteca também oferece uma variedade de bebidas e comidas.",
                        Foto = "/imgpaises/img Itália/VidaNoturna/Yab Discoteca - Florença.png",
                        PaisId = 4,
                        Latitude = -43.77105116164101,
                        Longitude = -11.252713911719718
                        },


                        new Local () {
                        Id = 160,
                        Nome = "Bobino Milano (Milão)",
                        Localizacao = "Corso Vittorio Emanuele II, 22, 20122 Milano MI, Itália",
                        Telefone = "+39 345 254 9379",
                        HorarioFuncionamento = "De Sexta-feira das 23h às 4h e Sábado das 23h às 4h",
                        Descricao = "O Bobino Club é um clube noturno histórico localizado no centro de Milão, Itália. O clube foi fundado em 1958 e é conhecido por sua música ao vivo, DJs e eventos especiais. O Bobino Club oferece uma variedade de gêneros musicais, incluindo jazz, blues, rock e música eletrônica.",
                        Foto = "/imgpaises/img Itália/VidaNoturna/Bobino Milano- Milão.png",
                        PaisId = 4,
                        Latitude = -45.45373776306266,
                        Longitude = -9.16986454064268
                        },

                        new Local () {
                        Id = 161,
                        Nome = "Shari Vari Playhouse (Veneza)",
                        Localizacao = "Calle Lunga San Barnaba, 2772/A, 30123 Venezia VE, Itália",
                        Telefone = "+39 340 938 8410",
                        HorarioFuncionamento = "De Terça a sábado das 10h às 18h e de Domingo e segunda é Fechado",
                        Descricao = "Shari Vari Playhouse é um teatro de marionetes único e mágico localizado em Veneza, Itália. O teatro apresenta uma variedade de shows de marionetes para crianças e adultos, utilizando técnicas tradicionais e inovadoras. As apresentações são em italiano e inglês.",
                        Foto = "/imgpaises/img Itália/VidaNoturna/Shari Vari Playhouse - Veneza.png",
                        PaisId = 4,
                        Latitude = -41.89759875992729,
                        Longitude = -12.47611063676804
                        },


                        new Local () {
                        Id = 162,
                        Nome = "Phi Beach Club (Baia Sardinia)",
                        Localizacao = "Località Phi Beach, 07020 Baja Sardinia SS, Itália",
                        Telefone = "+39 342 838 4410",
                        HorarioFuncionamento = "Aberto todos os dias das 10h às 20h e Junho a setembro Aberto todos os dias das 10h às 2h",
                        Descricao = "O Phi Beach Club, em Baja Sardinia, é um oásis de pura elegância e sofisticação. Localizado na Costa Esmeralda da Sardenha, banhado por águas cristalinas e rodeado por uma natureza exuberante, o Phi Beach Club oferece aos seus visitantes uma experiência única e inesquecível.",
                        Foto = "/imgpaises/img Itália/VidaNoturna/Phi Beach Club - Baia Sardinia.png",
                        PaisId = 4,
                        Latitude = -41.14247704037138,
                        Longitude = -9.46688483857745
                        },
                #endregion

                #region IT Espiritualidade
                        new Local () {
                        Id = 163,
                        Nome = "Basílica de São Pedro - Vaticano (Roma)",
                        Localizacao = "Piazza San Pietro, 00120 Città del Vaticano, Itália",
                        Telefone = "+39 06 6988 3111",
                        HorarioFuncionamento = "De 1º de abril a 30 de setembro é Aberto das 7h às 19h De 1º de outubro a 31 de março é  Aberto das 7h às 18h30 das 8h às 17h",
                        Descricao = "A Basílica de São Pedro é uma das maiores igrejas do mundo e um dos locais religiosos mais importantes do cristianismo. Ela está localizada na Cidade do Vaticano, a menor nação do mundo, e é a sede do Papa.",
                        Foto = "/imgpaises/img Itália/Fe/Basílica de São Pedro - Vaticano (Roma).png",
                        PaisId = 4,
                        Latitude = -41.90312309115027,
                        Longitude = -12.453764763905507
                        },

                        new Local () {
                        Id = 164,
                        Nome = "Basílica de São Marcos (Veneza)",
                        Localizacao = "Piazza San Marco, 328, 30124 Venezia VE, Itália",
                        Telefone = "+39 041 271 5902",
                        HorarioFuncionamento = "De Segunda a sábado das 9h30 às 17h e de Domingos e feriados das 14h às 16h30 (de 16 de abril a 28 de outubro, até 17h)",
                        Descricao = "A Basílica de São Marcos é um dos edifícios mais emblemáticos de Veneza, Itália. É uma catedral em estilo bizantino que foi construída entre os séculos IX e XI. A basílica é dedicada a São Marcos, o santo padroeiro de Veneza.",
                        Foto = "/imgpaises/img Itália/Fe/Basílica de São Marcos - Veneza.png",
                        PaisId = 4,
                        Latitude = -42.0643056682679,
                        Longitude = -12.472640691886971
                        },

                        new Local () {
                        Id = 165,
                        Nome = "Duomo di Milano (Catedral de Milão) (Milão)",
                        Localizacao = "Piazza del Duomo, 20122 Milano MI, Itália",
                        Telefone = "+39 02 7202 3375",
                        HorarioFuncionamento = "De Segunda a sábado das 9h às 19h (última entrada às 18h10) e de Domingos e feriados das 9h às 17h (última entrada às 16h10)",
                        Descricao = "A Catedral de Milão, também conhecida como Duomo di Milano, é uma das maiores catedrais do mundo e um dos principais pontos turísticos da Itália. A catedral é dedicada à Natividade de Maria. A construção da catedral começou em 1386 e durou mais de seis séculos. A catedral é um exemplo impressionante da arquitetura gótica, com suas torres altas, suas esculturas detalhadas e seus vitrais coloridos.",
                        Foto = "/imgpaises/img Itália/Fe/Duomo di Milano (Catedral de Milão) - Milão.png",
                        PaisId = 4,
                        Latitude = -45.46584146001646,
                        Longitude = -9.192441225198895
                        },

                        new Local () {
                        Id = 166,
                        Nome = "Basílica de São Francisco de Assis (Assis)",
                        Localizacao = "Piazza San Francesco, 2, 06081 Assisi PG, Itália",
                        Telefone = "+39 075 812 041",
                        HorarioFuncionamento = "Aberto todos os dias das 6h até as 18h",
                        Descricao = "A Basílica de São Francisco de Assis é um dos locais religiosos mais importantes da Itália. É um complexo religioso que inclui duas basílicas, uma cripta e um museu. A basílica foi construída no século XIII para abrigar o túmulo de São Francisco de Assis, fundador da Ordem Franciscana.",
                        Foto = "/imgpaises/img Itália/Fe/Basílica de São Francisco de Assis - Assis.png",
                        PaisId = 4,
                        Latitude = -43.525663732419396,
                        Longitude = -11.89605563853403
                        },

                        new Local () {
                        Id = 167,
                        Nome = "Catedral de Santa Maria del Fiore (Florença)",
                        Localizacao = "Piazza del Duomo, 50122 Firenze FI, Itália",
                        Telefone = "+39 055 230 2880",
                        HorarioFuncionamento = "De Segunda a sábado das 10h às 17h (última entrada às 16h30) e de Domingos e feriados das 13h30 às 16h30 (última entrada às 16h)",
                        Descricao = "A Catedral de Santa Maria del Fiore, também conhecida como Duomo de Florença, é uma das maiores catedrais do mundo e um dos principais pontos turísticos da Itália. A catedral é dedicada à Nossa Senhora das Flores. A construção da catedral começou em 1296 e durou mais de 150 anos. A catedral é um exemplo impressionante da arquitetura gótica, com sua cúpula imponente, seus campanários altos e suas esculturas detalhadas.",
                        Foto = "/imgpaises/img Itália/Fe/Basílica de São Marcos - Veneza.png",
                        PaisId = 4,
                        Latitude = -43.77407279815551,
                        Longitude = -11.255444949372688
                        },


                        new Local () {
                        Id = 168,
                        Nome = "Catedral de Palermo (Palermo)",
                        Localizacao = "Via Vittorio Emanuele, 90, 90134 Palermo PA, Itália",
                        Telefone = "+39 091 334 377",
                        HorarioFuncionamento = "De Segunda a sábado das 7h30 às 19h30 Domingos e feriados das 8h às 13h e depois das 16h às 19h30",
                        Descricao = "A Catedral de Palermo, também conhecida como Duomo di Palermo, é uma catedral em estilo normando localizada em Palermo, Sicília, Itália. A catedral é dedicada à Assunção da Virgem Maria. A construção da catedral começou em 1185 e durou mais de 200 anos. A catedral é um exemplo impressionante da arquitetura normanda, com sua fachada ricamente decorada, seus mosaicos dourados e seus claustros.",
                        Foto = "/imgpaises/img Itália/Fe/Catedral de Palermo - Palermo.png",
                        PaisId = 4,
                        Latitude = -38.11473548009587,
                        Longitude = -13.355878448220029
                        },
                #endregion

                #region IT Restaurantes
                        new Local () {
                        Id = 169,
                        Nome = "Osteria Francescana (Modena)",
                        Localizacao = "Via Stella, 22, 41121 Modena MO, Itália",
                        Telefone = "+39 059 223 903",
                        HorarioFuncionamento = "De Quarta a sábado das 12h às 14h30 e depois das 19h30 às 22h e de Fechado domingo, segunda e terça-feira",
                        Descricao = "Osteria Francescana é um restaurante com três estrelas Michelin em Modena, Itália. É propriedade e operado pelo chef Massimo Bottura. O restaurante é considerado um dos melhores do mundo e foi nomeado o melhor restaurante do mundo em 2016 e 2018 pelo The World's 50 Best Restaurants.",
                        Foto = "/imgpaises/img Itália/Restaurantes/Osteria Francescana - Modena.png",
                        PaisId = 4,
                        Latitude = -44.64574053911844,
                        Longitude = -10.921229314649926
                        },

                        new Local () {
                        Id = 170,
                        Nome = "Trattoria da Romano (Veneza)",
                        Localizacao = "Calle del Forno, 2292/A, 30122 Venezia VE, Itália",
                        Telefone = "+39 041 522 2277",
                        HorarioFuncionamento = "De Terça a sábado das 12h às 14h30 e depois das 19h às 22h e é Fechado de domingo e segunda-feira",
                        Descricao = "Trattoria da Romano é um restaurante tradicional veneziano em Veneza, Itália. É um restaurante familiar que serve pratos venezianos autênticos há mais de 50 anos. O restaurante está localizado em um beco tranquilo no centro histórico de Veneza. O interior é acolhedor e rústico, com paredes de tijolos expostos e mesas de madeira.",
                        Foto = "/imgpaises/img Itália/Restaurantes/Trattoria da Romano - Veneza.png",
                        PaisId = 4,
                        Latitude = -45.4861839962346,
                        Longitude = -12.418251571887863
                        },

                        new Local () {
                        Id = 171,
                        Nome = "Dal Pescatore (Canneto sull'Oglio)",
                        Localizacao = "Via S. Antonio, 5, 25040 Canneto sull'Oglio MN, Itália",
                        Telefone = "+39 0376 714 010",
                        HorarioFuncionamento = "De Quarta a sábado das 12h30 às 14h30 e depois das 19h30 às 22h30 e de Domingo das 12h30 às 14h30 e Fechado de segunda e terça-feira",
                        Descricao = "Dal Pescatore é um restaurante com três estrelas Michelin em Canneto sull'Oglio, Itália. É propriedade e operado pelos chefs Nadia Santini, Giovanni Santini e Bruna Santini. O restaurante é considerado um dos melhores da Itália e foi nomeado o 48º melhor restaurante do mundo em 2009 pelo The World's 50 Best Restaurants.",
                        Foto = "/imgpaises/img Itália/Restaurantes/Dal Pescatore - Canneto sull'Oglio.png",
                        PaisId = 4,
                        Latitude = -45.17227493537136,
                        Longitude = -10.357242478405302
                        },

                        new Local () {
                        Id = 172,
                        Nome = "Enoteca Pinchiorri (Florença)",
                        Localizacao = "Via Ghibellina, 87, 50122 Firenze FI, Itália",
                        Telefone = "+39 055 200 7375",
                        HorarioFuncionamento = "De Terça a sábado das 12h30 às 14h30 e depois das 19h30 às 22h30 e Fechado de domingo e segunda-feira",
                        Descricao = "A Enoteca Pinchiorri é um restaurante com três estrelas Michelin em Florença, Itália. É propriedade e operado pelos chefs Annie Féolde e Giorgio Pinchiorri. O restaurante é considerado um dos melhores do mundo e foi nomeado o 32º melhor restaurante do mundo em 2008 pela revista British Restaurant.",
                        Foto = "/imgpaises/img Itália/Restaurantes/Enoteca Pinchiorri - Florença.png",
                        PaisId = 4,
                        Latitude = -43.77074190882861,
                        Longitude = -11.261363626632706
                        },

                        new Local () {
                        Id = 173,
                        Nome = "La Pergola (Roma)",
                        Localizacao = "Via Veneto, 150, 00187 Roma RM, Itália",
                        Telefone = "+39 06 488 7800",
                        HorarioFuncionamento = "De Terça a sábado das 12h30 às 14h30 e depois das 19h30 às 22h30 e Fechado de domingo e segunda-feira",
                        Descricao = " La Pergola é um restaurante com três estrelas Michelin em Roma, Itália. É propriedade e operado pelo chef Heinz Beck. O restaurante é considerado um dos melhores do mundo e foi nomeado o 18º melhor restaurante do mundo em 2023 pela revista The World's 50 Best Restaurants.",
                        Foto = "/imgpaises/img Itália/Restaurantes/La Pergola - Roma.png",
                        PaisId = 4,
                        Latitude = -41.91989097355584,
                        Longitude = -12.44605951057047
                        },

                        new Local () {
                        Id = 174,
                        Nome = "Antica Corte Pallavicina (Polesine Parmense)",
                        Localizacao = "Strada Palazzo, 7, 43010 Polesine Parmense PR, Itália",
                        Telefone = "+39 0524 936 669",
                        HorarioFuncionamento = "De Segunda a sábado das 12h30 às 14h30 e depois das 19h30 às 22h30, Domingo das 12h30 às 14h30 e Feriados das 12h30 às 14h30 (mediante reserva)",
                        Descricao = "Antica Corte Pallavicina é um restaurante com uma estrela Michelin em Polesine Parmense, Itália. É propriedade e operado pela família Spigaroli. O restaurante está situado em um antigo castelo do século XIV, às margens do rio Po.",
                        Foto = "/imgpaises/img Itália/Restaurantes/Antica Corte Pallavicina - Polesine Parmense.png",
                        PaisId = 4,
                        Latitude = -45.02267235453517,
                        Longitude = -10.08574894704006
                        },
                #endregion

                #region IT Cultura
                        new Local () {
                        Id = 175,
                        Nome = "Museu do Vaticano e Capela Sistina (Roma)",
                        Localizacao = "Viale Vaticano, 00165 Città del Vaticano",
                        Telefone = "+39 06 6988 3332",
                        HorarioFuncionamento = "De Segunda a sábado das 9h às 20h (última entrada às 16h) e Fechado de domingo",
                        Descricao = "Os Museus do Vaticano abrigam uma das maiores e mais importantes coleções de arte do mundo. Os museus estão localizados na Cidade do Vaticano, a menor cidade do mundo, e são a casa da Capela Sistina, que é considerada um dos mais importantes locais religiosos e artísticos do mundo.",
                        Foto = "/imgpaises/img Itália/Cultura/Museu do Vaticano e Capela Sistina - Roma.png",
                        PaisId = 4,
                        Latitude = -41.906839101819514,
                        Longitude = -12.453579559497973
                        },

                        new Local () {
                        Id = 176,
                        Nome = "Coliseu (Roma)",
                        Localizacao = "Piazza del Colosseo, 1, 00184 Roma RM, Itália",
                        Telefone = "+39 06 399 67 70",
                        HorarioFuncionamento = "De Segunda a sábado das 9h às 16h30 (última entrada às 16h) e Fechado dia 25 de dezembro e 1º de janeiro",
                        Descricao = "O Coliseu é um anfiteatro oval em Roma, Itália. É o maior anfiteatro do mundo e foi construído no século I d.C. pelo imperador Vespasiano. O Coliseu foi usado para combates de gladiadores, execuções e outros eventos públicos. O Coliseu é um Patrimônio Mundial da UNESCO e uma das atrações turísticas mais populares da Itália. O Coliseu está aberto ao público para visitas guiadas e autoguiadas.",
                        Foto = "/imgpaises/img Itália/Cultura/Coliseu - Roma.png",
                        PaisId = 4,
                        Latitude = -41.9068708106922,
                        Longitude = -12.45364393136315
                        },

                        new Local () {
                        Id = 177,
                        Nome = "Museu Uffizi (Florença)",
                        Localizacao = "Piazzale degli Uffizi, 6, 50122 Firenze FI, Itália",
                        Telefone = "+39 055 294883",
                        HorarioFuncionamento = "De Terça a domingo das 8h15 às 18h50 (última entrada às 18h05) e Fechado de segunda-feira, 1º de janeiro, 1º de maio e 25 de dezembro",
                        Descricao = "A Galleria degli Uffizi é um museu de arte em Florença, Itália. É um dos museus mais importantes do mundo e abriga uma vasta coleção de pinturas e esculturas do Renascimento italiano.",
                        Foto = "/imgpaises/img Itália/Cultura/Museu Uffizi - Florença.png",
                        PaisId = 4,
                        Latitude = -43.769643198347396,
                        Longitude = -11.25539636411926
                        },

                        new Local () {
                        Id = 178,
                        Nome = "Pompeia (Pompeia)",
                        Localizacao = "Pompéia, Itália",
                        Telefone = "+39 081 857 5347",
                        HorarioFuncionamento = "Aberto todos os dias das 9h às 17h (última entrada às 16h) e Fechado em 25 de dezembro e 1º de janeiro",
                        Descricao = "Pompeia é uma antiga cidade romana que foi enterrada por uma erupção do Vesúvio em 79 d.C. A cidade está localizada na Itália, perto de Nápoles. As ruínas de Pompéia são um Patrimônio Mundial da UNESCO e um destino turístico popular.",
                        Foto = "/imgpaises/img Itália/Cultura/Pompeia.png",
                        PaisId = 4,
                        Latitude = -40.75097322205805,
                        Longitude = -14.501137636010677
                        },

                        new Local () {
                        Id = 179,
                        Nome = "Palazzo Ducale (Palácio Ducal) (Veneza)",
                        Localizacao = "Piazza San Marco, 1, 30124 Venezia VE, Itália",
                        Telefone = "+39 041 271 5934",
                        HorarioFuncionamento = "Aberto todos os dias das 8h30 às 19h (última entrada às 18h) e Fechado em 25 de dezembro e 1º de janeiro",
                        Descricao = "O Palazzo Ducale (Palácio Ducal) é um dos edifícios mais emblemáticos de Veneza, Itália. Foi a sede do governo da República de Veneza durante séculos e é um dos maiores e mais impressionantes palácios góticos do mundo.",
                        Foto = "/imgpaises/img Itália/Cultura/Palazzo Ducale (Palácio Ducal) - Veneza.png",
                        PaisId = 4,
                        Latitude = -45.434063029429126,
                        Longitude = -12.339959987562988
                        },

                        new Local () {
                        Id = 180,
                        Nome = "Piazza del Campo e Palazzo Pubblico (Siena)",
                        Localizacao = "Piazza del Campo, 53100 Siena SI, Itália",
                        Telefone = "+39 0577 292 222",
                        HorarioFuncionamento = "Aberto todos os dias 24h",
                        Descricao = "A Piazza del Campo é a principal praça de Siena, Itália. É uma das praças mais famosas da Itália e é conhecida por sua forma de concha e por sua beleza arquitetônica. A praça é o lar de vários edifícios históricos, incluindo o Palazzo Pubblico, a Torre del Mangia e a Fonte Gaia.",
                        Foto = "/imgpaises/img Itália/Cultura/Piazza del Campo e Palazzo Pubblico - Siena.png",
                        PaisId = 4,
                         Latitude = -43.31825623772815,
                        Longitude = -11.331932240398123
                        },
                #endregion
        #endregion
        
        #region Portugal
                // 181 a 216
                #region PT Natureza
                new Local () {
                        Id = 181,
                        Nome = "Zoológico de Lisboa (Lisboa)",
                        Localizacao = "Estrada de Benfica 72, 1500-474 Lisboa",
                        Telefone = "+351 217780200",
                        HorarioFuncionamento = "De Novembro a fevereiro das 10h às 18h (última entrada às 17h) e de Março a outubro das 10h às 19h (última entrada às 18h)",
                        Descricao = "O Jardim Zoológico de Lisboa, fundado em 1884, é um dos mais antigos da Europa. Abriga cerca de 2000 animais de 300 espécies diferentes, em habitats recriados para simular seus ambientes naturais. O zoológico também desenvolve programas de conservação e investigação científica.",
                        Foto = "/imgpaises/img Portugal/Natureza/Zoológico de Lisboa (Lisboa).png",
                        PaisId = 6,
                        Latitude = -38.743250364769374,
                        Longitude = -9.169150259221473
                },

                new Local () {
                        Id = 182,
                        Nome = "Zoomarine Algarve (Albufeira)",
                        Localizacao = "Estrada Nacional 125, Guia, 8200-864 Albufeira",
                        Telefone = "+351 289560300",
                        HorarioFuncionamento = "Não abre de segunda e terça e nos outros dias abre das 10h até as 17h.",
                        Descricao = "O Zoomarine Algarve é um parque temático que combina diversão com educação ambiental. Abriga uma grande variedade de animais, incluindo golfinhos, focas, leões marinhos, aves de rapina e tubarões. O parque oferece shows com animais, apresentações educativas, atrações aquáticas e muito mais. ",
                        Foto = "/imgpaises/img Portugal/Natureza/Zoomarine Algarve (Albufeira).png",
                        PaisId = 6,
                        Latitude = -37.12725446163808,
                        Longitude = -8.314391226306187
                },

                new Local () {
                        Id = 183,
                        Nome = "Mata Nacional do Bussaco (Luso)",
                        Localizacao = "Mata Nacional do Buçaco, 3540-504 Luso",
                        Telefone = "+351 231540100",
                        HorarioFuncionamento = "Aberto todos os dias 24h.",
                        Descricao = "A Mata Nacional do Buçaco é uma floresta nacional localizada na Serra do Buçaco, no município da Mealhada, em Portugal. A mata foi originalmente plantada por monges carmelitas no século XVII e é agora um Monumento Nacional. A Mata Nacional do Buçaco é conhecida por sua beleza natural, com uma variedade de árvores e plantas, incluindo o famoso cedro-do-Buçaco. A mata também abriga uma variedade de animais selvagens, como veados, javalis e raposas.",
                        Foto = "/imgpaises/img Portugal/Natureza/Mata Nacional do Bussaco (Luso).png",
                        PaisId = 6,
                         Latitude = -40.377267388811504,
                        Longitude = -8.36691894751412
                },

                        new Local () {
                        Id = 184,
                        Nome = "Parque Biológico de Gaia (Vila Nova de Gaia)",
                        Localizacao = "Lugar da Lavandeira, 4400-448 Avintes, Vila Nova de Gaia",
                        Telefone = "+351 223743737",
                        HorarioFuncionamento = "De Terça a sexta das 9h às 18h, Sábado e domingo das 10h às 19h e Fechado de Segundas-feiras, 1º de janeiro, 1º de maio e 25 de dezembro",
                        Descricao = "O Parque Biológico de Gaia é um centro de educação ambiental que promove a compreensão da natureza e da importância da sua preservação. O parque possui uma área de 35 hectares, onde se podem encontrar diversos habitats naturais, como bosques, carvalhais, pinhais, lagos e ribeiros. O parque também abriga uma grande variedade de animais selvagens, como aves, répteis e mamíferos.",
                        Foto = "/imgpaises/img Portugal/Natureza/Parque Biológico de Gaia (Vila Nova de Gaia).png",
                        PaisId = 6,
                         Latitude = -41.0975290451504,
                        Longitude = -8.554217159114284
                },

                new Local () {
                        Id = 185,
                        Nome = "Lisboa Oceanarium (Lisboa)",
                        Localizacao = "Esplanada D. Carlos I, 1990-005 Lisboa",
                        Telefone = "+351 218917000",
                        HorarioFuncionamento = "Todos os dias das 10h às 20h (última entrada às 19h), 25 de dezembro das 13h às 18h e 1º de janeiro das 12h às 18h",
                        Descricao = "O Oceanário de Lisboa é um dos maiores aquários da Europa. Abriga mais de 8.000 animais marinhos de 500 espécies diferentes, de todos os oceanos do mundo. O Oceanário está dividido em quatro habitats: Atlântico Norte, Pacífico, Índico e Antártida. Os visitantes podem observar os animais através de grandes painéis de vidro, aprender sobre a importância da preservação dos oceanos e participar em diversas atividades educativas.",
                        Foto = "/imgpaises/img Portugal/Natureza/Lisboa Oceanarium (Lisboa).png",
                        PaisId = 6,
                         Latitude = -38.76375261307688,
                        Longitude = -9.093698588057261
                },

                new Local () {
                        Id = 186,
                        Nome = "Parque Natural do Alvão (região do Alto Douro)",
                        Localizacao = "Apartado 10, 5085-401 Vila Real",
                        Telefone = "+351 254675289",
                        HorarioFuncionamento = "Aberto todos os dias 24h.",
                        Descricao = "O Parque Natural do Alvão é uma área protegida localizada na região do Alto Douro, em Portugal. O parque foi criado em 1983 e abrange uma área de cerca de 72 km². O parque é conhecido por sua beleza natural, com paisagens montanhosas, florestas densas e rios cristalinos. O parque também abriga uma grande variedade de animais selvagens, como lobos, veados e aves de rapina.",
                        Foto = "/imgpaises/img Portugal/Natureza/Parque Natural do Alvão (região do Alto Douro).png",
                        PaisId = 6,
                         Latitude = -41.3656874920189,
                        Longitude = -7.817695730265091
                },
                #endregion

                #region PT Compras 
                new Local () {
                Id = 187,
                Nome = "Centro Comercial Colombo (Lisboa)",
                Localizacao = "Avenida Lusíada, 1500-454 Lisboa",
                Telefone = "+351 217160300",
                HorarioFuncionamento = "De Segunda a sexta das 10h às 23h e de Sábado, domingo e feriados das 10h às 22h",
                Descricao = "O Centro Comercial Colombo é o maior centro comercial da Península Ibérica em número total de lojas. Abriga mais de 340 lojas, restaurantes e cafés, além de um cinema, um bowling e um parque infantil. O centro comercial está localizado em Benfica, próximo ao Estádio da Luz.",
                Foto = "/imgpaises/img Portugal/Compras/Centro Comercial Colombo (Lisboa).png",
                PaisId = 6,
                 Latitude = -38.75373640825004,
                 Longitude = -9.188423589914175
                },

                new Local () {
                Id = 188,
                Nome = "Algarve Shopping (Albufeira)",
                Localizacao = "EN125, Guia, 8200-577 Albufeira",
                Telefone = "+351 289589400",
                HorarioFuncionamento = "De Segunda a sábado das 10h às 23h e de Domingo e feriados das10h às 22h",
                Descricao = "O Algarve Shopping é um centro comercial moderno e espaçoso, com mais de 120 lojas, restaurantes e cafés. O centro comercial oferece uma grande variedade de opções de compras, desde lojas de roupas e acessórios até lojas de eletrônicos e artigos para o lar. O Algarve Shopping também possui um cinema, um bowling e um parque infantil, o que o torna um ótimo lugar para se divertir com a família ou amigos.",
                Foto = "/imgpaises/img Portugal/Compras/Algarve Shopping (Albufeira).png",
                PaisId = 6,
                 Latitude = -37.127768674366706,
                Longitude = -8.280230847658009
                },

                new Local () {
                Id = 189,
                Nome = "Forum Algarve (Faro)",
                Localizacao = "Estrada Nacional 125, Km 103, 8005-405 Faro",
                Telefone = "+351 289889300",
                HorarioFuncionamento = "De Segunda a sábado das 10h às 23h e de Domingo e feriados das10h às 22h",
                Descricao = "O Forum Algarve é um centro comercial moderno e espaçoso, com mais de 100 lojas, restaurantes e cafés. O centro comercial oferece uma grande variedade de opções de compras, desde lojas de roupas e acessórios até lojas de eletrônicos e artigos para o lar. O Forum Algarve também possui um cinema, um bowling e um parque infantil, o que o torna um ótimo lugar para se divertir com a família ou amigos.",
                Foto = "/imgpaises/img Portugal/Compras/Forum Algarve (Faro).png",
                PaisId = 6,
                 Latitude = -37.02893134981553,
                Longitude = -7.945094188132468
                },

                new Local () {
                Id = 190,
                Nome = "Aqua Portimao (Portimão)",
                Localizacao = "Avenida Dr. Francisco Sá Carneiro, Loja 105, 8500-457 Portimão",
                Telefone = "+351 282420740",
                HorarioFuncionamento = "De Segunda a sexta das 10h às 23h e Sábado, domingo e feriados das 10h às 22h",
                Descricao = "O Aqua Portimão é um centro comercial moderno e espaçoso, com mais de 100 lojas, restaurantes e cafés. O centro comercial oferece uma grande variedade de opções de compras, desde lojas de roupas e acessórios até lojas de eletrônicos e artigos para o lar. O Aqua Portimão também possui um cinema, um bowling e um parque infantil, o que o torna um ótimo lugar para se divertir com a família ou amigos.",
                Foto = "/imgpaises/img Portugal/Compras/Aqua Portimao (Portimão).png",
                PaisId = 6,
                 Latitude = -37.147922603471706,
                Longitude = -8.543617889983876
                },

                new Local () {
                Id = 191,
                Nome = "El Corte Inglés (Lisboa)",
                Localizacao = "Avenida António Augusto Aguiar, 33, 1049-001 Lisboa",
                Telefone = "+351 213538300",
                HorarioFuncionamento = "De Segunda a sábado das 10h às 23h e de Domingo e feriados das 10h às 22h",
                Descricao = "O El Corte Inglés de Lisboa é um gigante comercial vibrante, pronto para atender a todos os seus desejos. Explore os diversos departamentos, desde a moda e beleza até a tecnologia e lazer, e encontre tudo o que precisa e muito mais. Saboreie uma deliciosa refeição no restaurante ou relaxe com um café e um lanche na cafeteria. A loja também oferece uma gama de serviços convenientes, como salão de beleza, lavanderia e estacionamento gratuito.",
                Foto = "/imgpaises/img Portugal/Compras/El Corte Inglés (Lisboa).png",
                PaisId = 6,
                 Latitude = -38.73338957143639,
                Longitude = -9.153756845731863
                },

                new Local () {
                Id = 192,
                Nome = "Freeport Lisboa Fashion Outlet  Alcochete",
                Localizacao = "Avenida Euro 2004, Alcochete 2890-154 Portugal",
                Telefone ="+351 21 234 3501" ,
                HorarioFuncionamento = "10:00 ás 22:00",
                Descricao = "Situado em Alcochete, a apenas 30 minutos de Lisboa e com passagem por uma das mais belas pontes da Europa, a ponte Vasco da Gama, o Freeport Lisboa Fashion Outlet é o local perfeito para um dia em cheio. Com mais de 150 marcas com descontos até 70% durante todo o ano, é o destino de shopping ideal para quem procura grandes marcas nacionais e internacionais. Aqui pode encontrar vestuário para homem, senhora e criança, acessórios de moda, perfumarias e uma excelência de serviços que contribuirão para tornar a sua experiência inesquecível. No Freeport Lisboa Fashion Outlet, a tradição e a modernidade dão origem a um lugar especial. A arquitetura eclética onde o traçado contemporâneo está em harmonia com o tradicional, as áreas de repouso e lazer, os espaços relvados e as zonas de água dão origem a um espaço comercial com caraterísticas únicas." ,
                Foto = "/imgpaises/img Portugal/Compras/Freeport Lisboa Fashion Outlet - Alcochete.jpg",
                PaisId = 6,
                 Latitude = -38.752079911052874,
                Longitude = -8.939183147587533
                },
                #endregion

                #region PT Vida Noturna
                new Local () {
                        Id = 193,
                        Nome = "Fábrica Braço de Prata (Lisboa)",
                        Localizacao = "Rua do Barranco, 4, 8400-510 Carvoeiro",
                        Telefone = "+351 282358456",
                        HorarioFuncionamento = "Aberto todos os dias 24h. ",
                        Descricao = "O Cocktail Garden é um bar elegante e relaxante, situado no coração de Carvoeiro. O bar oferece uma grande variedade de cocktails clássicos e contemporâneos, além de uma seleção de vinhos, cervejas e outras bebidas. O Cocktail Garden também oferece uma variedade de petiscos e snacks, perfeitos para acompanhar a sua bebida.",
                        Foto = "/imgpaises/img Portugal/VidaNoturna/Fábrica Braço de Prata (Lisboa).png",
                        PaisId = 6,
                        Latitude = -38.74389138745578,
                        Longitude = -9.101252932241328
                },

                new Local () {
                        Id = 194,
                        Nome = "Cinco Lounge (Lisboa)",
                        Localizacao = "Avenida António Augusto Aguiar, 33, 1049-001 Lisboa",
                        Telefone = "+351 213538300",
                        HorarioFuncionamento = "De Segunda a sábado das 10h às 23h e de Domingo e feriados das 10h às 22h",
                        Descricao = "O Cinco Lounge está situado no coração da Avenida António Augusto Aguiar, em Lisboa, e oferece um ambiente elegante e relaxante para desfrutar de uma bebida ou uma refeição leve.",
                        Foto = "/imgpaises/img Portugal/VidaNoturna/Cinco Lounge (Lisboa).png",
                        PaisId = 6,
                        Latitude = -38.7142904434252,
                        Longitude = -9.149672159222808
                },

                new Local () {
                        Id = 195,
                        Nome = "Cocktail Garden  (Carvoeiro)",
                        Localizacao = "Rua do Barranco, 4, 8400-510 Carvoeiro",
                        Telefone = "+351 282358456",
                        HorarioFuncionamento = "Aberto todos os dias das 12h até as 23h",
                        Descricao = "O Cocktail Garden é um bar elegante e relaxante, situado no coração de Carvoeiro. O bar oferece uma grande variedade de cocktails clássicos e contemporâneos, além de uma seleção de vinhos, cervejas e outras bebidas. O Cocktail Garden também oferece uma variedade de petiscos e snacks, perfeitos para acompanhar a sua bebida.",
                        Foto = "/imgpaises/img Portugal/VidaNoturna/Cocktail Garden  (Carvoeiro).png",
                        PaisId = 6,
                        Latitude = -37.0982379061237,
                        Longitude = -8.473858845802814
                },

                new Local () {
                        Id = 196,
                        Nome = "USAxe Club (Porto)",
                        Localizacao = "Rua do Dr. Barbosa de Castro, 40, 4000-252 Porto",
                        Telefone = "+351 226094594",
                        HorarioFuncionamento = "De Sexta-feira das 23h às 6h e de Sábado das 23h às 6h",
                        Descricao = "O USAxe Club é uma discoteca vibrante e moderna, localizada no coração do Porto. O clube oferece uma experiência de festa única, com música de alta qualidade, DJs internacionais e uma pista de dança espaçosa.",
                        Foto = "/imgpaises/img Portugal/VidaNoturna/USAxe Club (Porto).png",
                        PaisId = 6,
                        Latitude = -38.70315114506938,
                        Longitude = -9.179124447589672
                },

                new Local () {
                        Id = 197,
                        Nome = "Largo da Oliveira (Guimarães)",
                        Localizacao = "Largo da Oliveira, 4800-415 Guimarães",
                        Telefone = "+351 226094594",
                        HorarioFuncionamento = "Aberto todos os dias 24h",
                        Descricao = "O Largo da Oliveira é uma praça histórica e monumental situada no centro histórico de Guimarães, Portugal. A praça é considerada o berço da nacionalidade portuguesa, pois foi neste local que D. Afonso Henriques, o primeiro rei de Portugal, proclamou a independência do país em 1143.",
                        Foto = "/imgpaises/img Portugal/VidaNoturna/Largo da oliveira (Guimarães).png",
                        PaisId = 6,
                        Latitude = -41.44316263594313,
                        Longitude = -8.292889705137778
                },

                new Local () {
                        Id = 198,
                        Nome = "Sky Bar (Lisboa)",
                        Localizacao = "Avenida da Liberdade, 185, 9º andar, 1049-001 Lisboa",
                        Telefone = "+351 213538300",
                        HorarioFuncionamento = "De Segunda a quinta das18h às 02h e de Sexta a domingo das 18h às 03h",
                        Descricao = "O Sky Bar Lisboa by SEEN é um bar rooftop elegante e sofisticado, situado no topo do Tivoli Avenida Liberdade Hotel. O bar oferece uma vista panorâmica deslumbrante da cidade de Lisboa, cocktails criativos e uma atmosfera vibrante.",
                        Foto = "/imgpaises/img Portugal/VidaNoturna/Sky Bar (Lisboa).png",
                        PaisId = 6,
                        Latitude = -38.72199282418489,
                        Longitude = -9.147618176632783
                },
                #endregion

                #region PT Espiritualidade
                new Local () {
                        Id = 199,
                        Nome = "Mosteiro da Batalha (Batalha)",
                        Localizacao = "Largo da Batalha, 2440-406 Batalha",
                        Telefone = "+351 244766200",
                        HorarioFuncionamento = "De Outubro a abril das 9h às 18h (última entrada às 17h30), Maio a setembro das 9h às 19h (última entrada às 18h30) e Encerrado em 25 de dezembro e 1 de janeiro",
                        Descricao = "O Mosteiro da Batalha é um dos mais importantes monumentos religiosos e históricos de Portugal. O mosteiro foi mandado construir pelo rei D. João I em 1386, em cumprimento de uma promessa feita à Virgem Maria pela vitória na Batalha de Aljubarrota. O mosteiro é um exemplar da arquitetura gótica portuguesa, com elementos manuelinos e renascentistas.",
                        Foto = "/imgpaises/img Portugal/Fe/Mosteiro da Batalha (Batalha).png",
                        PaisId = 6,
                        Latitude = -39.659348443140594,
                        Longitude = -8.825486259180503
                },

                new Local () {
                        Id = 200,
                        Nome = "Mosteiro de Alcobaça (Alcobaça)",
                        Localizacao = "Largo Dom Afonso Henriques, 2400-001 Alcobaça",
                        Telefone = "+351 262590274",
                        HorarioFuncionamento = "De Outubro a abril das 9h às 18h (última entrada às 17h30), Maio a setembro das 9h às 19h (última entrada às 18h30) e Encerrado em 25 de dezembro e 1 de janeiro",
                        Descricao = "O Mosteiro de Alcobaça é um dos mais importantes monumentos religiosos e históricos de Portugal. O mosteiro foi fundado em 1153 por D. Afonso Henriques, o primeiro rei de Portugal, e D. Bernardo de Claraval, fundador da Ordem de Cister. O mosteiro é um exemplar da arquitetura gótica portuguesa, com elementos manuelinos e renascentistas.",
                        Foto = "/imgpaises/img Portugal/Fe/Mosteiro de Alcobaça (Alcobaça).png",
                        PaisId = 6,
                        Latitude = -39.54840762063766,
                        Longitude = -8.979553059185564
                },

                new Local () {
                        Id = 201,
                        Nome = "Sé do Porto (Porto)",
                        Localizacao = "Terreiro da Sé, 4050-573 Porto",
                        Telefone = "+351 222002754",
                        HorarioFuncionamento = "De Segunda a sexta das 9h às 19h, Sábado das 9h às 12h30 e depois das 14h às 19h e de Domingo das 14h às 19h",
                        Descricao = "A Sé do Porto, também conhecida como Catedral do Porto, é um dos principais monumentos da cidade do Porto e um dos mais importantes monumentos religiosos de Portugal. A sua construção iniciou-se no século XII e, ao longo dos séculos, sofreu diversas remodelações, o que resultou numa mistura de estilos arquitetónicos, com destaque para o românico, o gótico e o barroco.",
                        Foto = "/imgpaises/img Portugal/Fe/Sé do Porto (Porto).png",
                        PaisId = 6,
                        Latitude = -41.143014662751,
                        Longitude = -8.611062859112177
                },

                new Local () {
                        Id = 202,
                        Nome = "Basílica da Estrela (Lisboa)",
                        Localizacao = "Praça da Estrela, 1200-669 Lisboa ",
                        Telefone = "+351 213962434",
                        HorarioFuncionamento = "De Segunda a sexta das 9h às 13h e depois das 15h às 19h, Sábado das  9h às 13h e 14h às 18h e de Domingo das 14h às 18h ",
                        Descricao = "A Basílica da Estrela, também conhecida como Real Basílica e Convento do Santíssimo Coração de Jesus, é um dos mais importantes monumentos religiosos de Lisboa. A sua construção iniciou-se no final do século XVIII em estilo barroco e neoclássico. ",
                        Foto = "/imgpaises/img Portugal/Fe/Basílica da Estrela (Lisboa).png",
                        PaisId = 6,
                        Latitude = -38.7135403492057,
                        Longitude = -9.160819688059483
                },

                new Local () {
                        Id = 203,
                        Nome = "Catedral de Évora (Évora)",
                        Localizacao = "Largo Marquês de Marialva, 7000-586 Évora  ",
                        Telefone = "+351 266742422",
                        HorarioFuncionamento = "De Segunda a sexta das 9h às 12h30 e depois das 14h às 18h, Sábado das 9h às 12h30 e de Domingo das 14h às 18h ",
                        Descricao = "A Catedral de Évora, também conhecida como Sé de Évora, é um dos mais importantes monumentos religiosos de Portugal e a maior catedral medieval do país. A sua construção iniciou-se no século XII em estilo românico, mas ao longo dos séculos sofreu diversas remodelações, o que resultou numa mistura de estilos arquitetónicos, com destaque também para o gótico e o barroco. ",
                        Foto = "/imgpaises/img Portugal/Fe/Catedral de Évora (Évora).png",
                        PaisId = 6,
                        Latitude = -38.57191515748675,
                        Longitude = -7.906867532248952
                },

                new Local () {
                        Id = 204,
                        Nome = "Basílica da Santíssima Trindade (Fátima)",
                        Localizacao = "Santuário de Fátima, 2495-400 Fátima ",
                        Telefone = "+351 249539600",
                        HorarioFuncionamento = "Todos os dias das 08h até as 19h ",
                        Descricao = "A Basílica da Santíssima Trindade é a mais recente construção do complexo do Santuário de Fátima. A sua construção iniciou-se em 2004 e foi concluída em 2007. A igreja é dedicada à Santíssima Trindade e tem capacidade para 8.633 pessoas sentadas. ",
                        Foto = "/imgpaises/img Portugal/Fe/Basílica da Santíssima Trindade (Fátima).png",
                        PaisId = 6,
                        Latitude = -39.62983053474812,
                        Longitude = -8.675358962894771
                },
                #endregion

                #region PT Restaurantes
                new Local () {
                        Id = 205,
                        Nome = "Delfina Restaurant (Lisboa)",
                        Localizacao = "Rua Domingos Sequeira, 23, 1200-174 Lisboa ",
                        Telefone = "+351 213421735",
                        HorarioFuncionamento = "De Terça a sexta das 12h30 às 15h30 e depois das 19h30 às 22h30, Sábado das 12h30 às 15h30 e depois das 19h30 às 23h00 e de Domingo e Segunda é Fechado  ",
                        Descricao = "O Restaurante Delfina é um restaurante português tradicional localizado no coração de Lisboa. O restaurante é conhecido pela sua comida deliciosa, ambiente acolhedor e serviço atencioso.  ",
                        Foto = "/imgpaises/img Portugal/Restaurantes/Delfina Restaurant.png",
                        PaisId = 6,
                        Latitude = -38.708326353903175,
                        Longitude = -9.139260545732979
                },

                new Local () {
                        Id = 206,
                        Nome = "Confeitaria Nacional (Lisboa)",
                        Localizacao = "Praça da Figueira 18B, 1100-241 Lisboa ",
                        Telefone = "+351 213424470",
                        HorarioFuncionamento = "De Segunda a sexta das 8h30 às 20h e de Sábado e domingo das 8h30 às 19h   ",
                        Descricao = "A Confeitaria Nacional é a confeitaria mais antiga de Lisboa, fundada em 1829. A confeitaria é conhecida pelos seus doces tradicionais portugueses, como os pastéis de nata, os travesseiros de Sintra e os bolos de arroz.  ",
                        Foto = "/imgpaises/img Portugal/Restaurantes/Confeitaria Nacional (Lisboa).png",
                        PaisId = 6,
                        Latitude = -38.71336187443325,
                        Longitude = -9.137872301549589
                },


                new Local () {
                        Id = 207,
                        Nome = "Restaurante o Melro (Almeirim)",
                        Localizacao = "Rua do Comércio, 12, 2080-047 Almeirim  ",
                        Telefone = "+351 243592422",
                        HorarioFuncionamento = "De Terça a sexta das 12h30 às 15h30 e depois das 19h30 às 22h30, Sábado das 12h30 às 15h30 e depois das 19h30 às 23h00 e de Domingo e Segunda é Fechado  ",
                        Descricao = "O Restaurante O Melro é um restaurante português tradicional, com foco em pratos regionais do Ribatejo. O restaurante é conhecido pela sua comida deliciosa, ambiente familiar e serviço atencioso. ",
                        Foto = "/imgpaises/img Portugal/Restaurantes/Restaurante o melro (Almeirim).png",
                        PaisId = 6,
                        Latitude = -39.26567801431487,
                        Longitude = -8.696338847564643
                },

                new Local () {
                        Id = 208,
                        Nome = "Café Progresso (Ponta Delgada)",
                        Localizacao = "Avenida Infante Dom Henrique, 54, 9500-352 Ponta Delgada ",
                        Telefone = "+351 296282340",
                        HorarioFuncionamento = "De Segunda a sexta das 7h30 às 20h, Sábado das 8h às 19h e de Domingo é Fechado ",
                        Descricao = "O Café Progresso é um café histórico e tradicional em Ponta Delgada, Açores. O café foi fundado em 1875 e é conhecido pela sua decoração Art Déco, ambiente acolhedor e serviço atencioso.  ",
                        Foto = "/imgpaises/img Portugal/Restaurantes/Café Progresso (Ponta Delgada).png",
                        PaisId = 6,
                        Latitude = -39.43746539335501,
                        Longitude = -8.303329305230193
                },

                new Local () {
                        Id = 209,
                        Nome = "Restaurante Ramila (Guimarães)",
                        Localizacao = "Rua de Santa Maria, 34, 4800-437 Guimarães ",
                        Telefone = "+351 253422325",
                        HorarioFuncionamento = "De Terça a sábado das 12h30 às 15h30 e depois das 19h30 às 22h30 e de Domingo e Segunda é Fechado ",
                        Descricao = "O Restaurante Ramila é um restaurante tradicional português, especializado em pratos regionais do Minho. O restaurante é conhecido pela sua comida deliciosa, ambiente familiar e serviço atencioso.   ",
                        Foto = "/imgpaises/img Portugal/Restaurantes/Restaurante Ramila (Guimarães).png",
                        PaisId = 6,
                        Latitude = -39.60102095899064,
                        Longitude = -8.609053332255911
                },

                new Local () {
                        Id = 210,
                        Nome = "Restaurante 7 Saias (Faro)",
                        Localizacao = "Rua do Prior, 20, 8000-336 Faro  ",
                        Telefone = "+351 289823997",
                        HorarioFuncionamento = "De Quarta a sábado das 19h30 às 22h30 e de Domingo a terça é Fechado ",
                        Descricao = "O Restaurante 7 Saias é um restaurante de alta gastronomia em Faro, Algarve. O restaurante é conhecido pela sua comida criativa e inovadora, ambiente elegante e serviço impecável.   ",
                        Foto = "/imgpaises/img Portugal/Restaurantes/Restaurante 7 Saias (Faro).png",
                        PaisId = 6,
                        Latitude = -39.59742204290333,
                        Longitude = -9.071464847549697
                },
                #endregion

                #region PT Cultura
                new Local () {
                        Id = 211,
                        Nome = "Palácio Nacional de Mafra (Mafra)",
                        Localizacao = "Terreiro D. João V, 2640-504 Mafra,  ",
                        Telefone = "+351 219851000 ",
                        HorarioFuncionamento = "De Terça a domingo das 9h às 18h (última entrada às 17h30) e Fechado em 25 de dezembro e 1 de janeiro  ",
                        Descricao = "O Palácio Nacional de Mafra é um conjunto monumental barroco do século XVIII, situado na cidade de Mafra, a cerca de 30 km de Lisboa. O conjunto inclui o Palácio, a Basílica, o Convento e a Tapada Nacional de Mafra.  ",
                        Foto = "/imgpaises/img Portugal/Cultura/Palácio Nacional de Mafra (Mafra).png",
                        PaisId = 6,
                        Latitude = -38.937150613254424,
                        Longitude = -9.326058449435786
                },

                new Local () {
                        Id = 212,
                        Nome = "Universidade de Coimbra (Coimbra) ",
                        Localizacao = "Paço das Escolas, Largo da Portagem, 3000-456 Coimbra  ",
                        Telefone = "+351 239 802 000  ",
                        HorarioFuncionamento = "De segunda a sexta das 9h até as 18h ",
                        Descricao = "A Universidade de Coimbra (UC) é a mais antiga universidade de Portugal e uma das mais antigas da Europa. Foi fundada em 1290 e está classificada como Património Mundial da UNESCO desde 2013.   ",
                        Foto = "/imgpaises/img Portugal/Cultura/Universidade de Coimbra (Coimbra).png",
                        PaisId = 6,
                        Latitude = -40.20787698890864,
                        Longitude = -8.426114661012006
                },

                new Local () {
                        Id = 213,
                        Nome = "Palácio da Pena (Sintra) ",
                        Localizacao = "Estrada da Pena, Sintra 2710-605  ",
                        Telefone = "+351 21 923 7300 ",
                        HorarioFuncionamento = "De Outubro a abril das 10h às 18h (última entrada às 17h), Maio a setembro das 10h às 19h (última entrada às 18h)e  Fechado em 25 de dezembro e 1 de janeiro ",
                        Descricao = "O Palácio da Pena é um palácio romântico do século XIX, situado no topo da Serra de Sintra, a cerca de 30 km de Lisboa. O palácio foi mandado construir pelo rei D. Fernando II e é considerado um dos mais belos exemplos da arquitetura romântica do século XIX.",
                        Foto = "/imgpaises/img Portugal/Cultura/Palácio da Pena (Sintra).png",
                        PaisId = 6,
                        Latitude = -38.78770215149572,
                        Longitude = -9.39066254758596
                },

                new Local () {
                        Id = 214,
                        Nome = "Torre de Belém (Lisboa) ",
                        Localizacao = "Avenida Brasília, 1400-038 Lisboa  ",
                        Telefone = "+351 21 362 0049  ",
                        HorarioFuncionamento = "De Terça a domingo das 10h às 18h (última entrada às 17h30) e Fechado em 1 de janeiro, Domingo de Páscoa, 1 de maio e 25 de dezembro ",
                        Descricao = "A Torre de Belém é uma torre fortificada do século XVI, situada na margem direita do rio Tejo, em Lisboa. A torre foi mandada construir pelo rei D. Manuel I e é considerada um dos mais importantes monumentos da arquitetura manuelina.    ",
                        Foto = "/imgpaises/img Portugal/Cultura/Torre de Belém (Lisboa).png",
                        PaisId = 6,
                        Latitude = -38.6918097719828,
                        Longitude = -9.215880743877257
                },

                new Local () {
                        Id = 215,
                        Nome = "Convento de Cristo (Tomar)",
                        Localizacao = ": Convento de Cristo, Largo do Convento de Cristo, 2300-312 Tomar ",
                        Telefone = "+351 249 315 040  ",
                        HorarioFuncionamento = "De Novembro a abril das 9h às 18h (última entrada às 17h30), Maio a outubro das 9h às 19h (última entrada às 18h30) e Fechado em 25 de dezembro e 1 de janeiro  ",
                        Descricao = "O Convento de Cristo é um monumento religioso e militar do século XII, situado na cidade de Tomar, a cerca de 130 km de Lisboa. O convento foi fundado pelos Templários e é considerado um dos mais importantes monumentos da arquitetura portuguesa     ",
                        Foto = "/imgpaises/img Portugal/Cultura/Convento de Cristo (Tomar).png",
                        PaisId = 6,
                        Latitude = -39.60354709860397,
                        Longitude = -8.418917072673116
                },

                new Local () {
                        Id = 216,
                        Nome = "Fortaleza de Sagres (Sagres) ",
                        Localizacao = "8650-356 Sagres  ",
                        Telefone = "+351 282 630 337   ",
                        HorarioFuncionamento = "De Novembro a abril das 10h às 17h30 (última entrada às 17h), Maio a outubro das 10h às 19h (última entrada às 18h) e Fechado em 25 de dezembro e 1 de janeiro  ",
                        Descricao = "A Fortaleza de Sagres é uma fortaleza militar do século XV, situada no extremo sudoeste da Europa, na cidade de Sagres, a cerca de 50 km de Lagos. A fortaleza foi mandada construir pelo Infante D. Henrique e é considerada um dos mais importantes monumentos da história da navegação portuguesa.    ",
                        Foto = "/imgpaises/img Portugal/Cultura/Fortaleza de Sagres (Sagres).png",
                        PaisId = 6,
                        Latitude = -37.000957964034804,
                        Longitude = -8.94824723231687
                }
                #endregion
        #endregion
        };
                builder.Entity<Local>().HasData(locais);
        }
}