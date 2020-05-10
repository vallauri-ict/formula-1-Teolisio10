ALTER TABLE [dbo].[Teams]  WITH CHECK ADD  CONSTRAINT [FK_Teams_Drivers_First] FOREIGN KEY([extFirstDriver])
REFERENCES [dbo].[Drivers] ([id]);

ALTER TABLE [dbo].[Teams]  WITH CHECK ADD  CONSTRAINT [FK_Teams_Drivers_Second] FOREIGN KEY([extSecondDriver])
REFERENCES [dbo].[Drivers] ([id]);

ALTER TABLE [dbo].[Teams]  WITH CHECK ADD  CONSTRAINT [FK_Teams_Countries] FOREIGN KEY([extCountry])
REFERENCES [dbo].[Countries] ([countryCode])
ON UPDATE CASCADE;


ALTER TABLE [dbo].[Drivers]  WITH CHECK ADD  CONSTRAINT [FK_Drivers_Countries] FOREIGN KEY([extCountry])
REFERENCES [dbo].[Countries] ([countryCode])
ON UPDATE CASCADE;


ALTER TABLE [dbo].[Races_Scores]  WITH CHECK ADD  CONSTRAINT [FK_Races_Scores_Drivers] FOREIGN KEY([extDriver])
REFERENCES [dbo].[Drivers] ([id])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[Races_Scores]  WITH CHECK ADD  CONSTRAINT [FK_Races_Scores_Races] FOREIGN KEY([extRace])
REFERENCES [dbo].[Races] ([id])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[Races_Scores]  WITH CHECK ADD  CONSTRAINT [FK_Races_Scores_Scores] FOREIGN KEY([extScore])
REFERENCES [dbo].[Scores] ([id])
ON UPDATE CASCADE;


ALTER TABLE [dbo].[Races]  WITH CHECK ADD  CONSTRAINT [FK_Races_Circuits] FOREIGN KEY([extCircuit])
REFERENCES [dbo].[Circuits] ([id])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[Races]  WITH CHECK ADD  CONSTRAINT [FK_Races_Countries] FOREIGN KEY([extCountry])
REFERENCES [dbo].[Countries] ([countryCode])
ON UPDATE NO ACTION;