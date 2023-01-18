CREATE TABLE [dbo].[EventoDetalles] (
    [ID_EvDetalles]   INT          IDENTITY (1, 1) NOT NULL,
    [ID_Evento]       INT          NOT NULL,
    [ID_Participante] INT          NOT NULL,
    [Estado]          VARCHAR (10) DEFAULT ('Activo') NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_EvDetalles] ASC)
);

