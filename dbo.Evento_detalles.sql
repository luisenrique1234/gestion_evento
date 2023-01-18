CREATE TABLE [dbo].[Evento_Detalles] (
    [ID_EvDetalles]   INT           NOT NULL IDENTITY,
    [ID_Evento]       INT NOT NULL,
    [ID_Participante] INT NOT NULL,
    [Estado] VARCHAR(10) NOT NULL DEFAULT 'Activo', 
    PRIMARY KEY CLUSTERED ([ID_EvDetalles] ASC)
)
