USE [DB_SistemaMicroondas]
GO

INSERT INTO [dbo].[Programas]
           ([Nome]
           ,[Comida]
           ,[TempoEmSegundos]
           ,[Potencia]
           ,[CaracterDeAquecimento]
           ,[Instrucoes]
           ,[Customizado])
     VALUES
 ('Pipoca', 'Pipoca (de micro-ondas)', 180, 7, '!', 'Observar o barulho de estouros do milho, caso houver um intervalo de mais de 10 segundos entre um estouro e outro, interrompa o aquecimento.', 0),
           ('Leite', 'Leite', 300, 5, '@', 'Cuidado com aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode causar fervura imediata causando risco de queimaduras.', 0),
           ('Carnes de boi', 'Carne em pedaço ou fatias', 840, 4, '#', 'Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.', 0),
           ('Frango', 'Frango (qualquer corte)', 480, 7, '$', 'Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.', 0),
           ('Feijão', 'Feijão congelado', 480, 9, '%', 'Deixe o recipiente destampado e em casos de plástico, cuidado ao retirar o recipiente pois o mesmo pode perder resistência em altas temperaturas.', 0)
          
GO
