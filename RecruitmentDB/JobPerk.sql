﻿CREATE TABLE [JobPerk] (
    [JobId]  INT NOT NULL,
    [PerkId] INT NOT NULL,
    CONSTRAINT [PK_JobPerk] PRIMARY KEY CLUSTERED ([JobId] ASC, [PerkId] ASC),
    CONSTRAINT [FK_JobPerk_Job] FOREIGN KEY ([JobId]) REFERENCES [Job] ([JobId]) ON DELETE CASCADE,
    CONSTRAINT [FK_JobPerk_Perk] FOREIGN KEY ([PerkId]) REFERENCES [Perk] ([PerkId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_JobId]
    ON [JobPerk]([JobId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_PerkId]
    ON [JobPerk]([PerkId] ASC);
