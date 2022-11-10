CREATE TABLE [dbo].[Crafts] (
    [cid]       INT            IDENTITY (1, 1) NOT NULL,
    [cname]     NVARCHAR (MAX) NOT NULL,
    [cprice]    INT            NOT NULL,
    [cdesc]     NVARCHAR (MAX) NOT NULL,
    [cimg]      NVARCHAR (MAX) NOT NULL,
    [ccategory] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Crafts] PRIMARY KEY CLUSTERED ([cid] ASC)
);