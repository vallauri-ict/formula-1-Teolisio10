ALTER TABLE [dbo].[Drivers]  WITH CHECK ADD  CONSTRAINT [FK_Drivers_Countries] FOREIGN KEY([extCountry])
REFERENCES [dbo].[Countries] ([countryCode])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[Teams]  WITH CHECK ADD  CONSTRAINT [FK_Teams_Countries] FOREIGN KEY([extCountry])
REFERENCES [dbo].[Countries] ([countryCode])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[Teams]  WITH CHECK ADD  CONSTRAINT [FK_Teams_Drivers_First] FOREIGN KEY([extFirstDriver])
REFERENCES [dbo].[Drivers] ([id]);

ALTER TABLE [dbo].[Teams]  WITH CHECK ADD  CONSTRAINT [FK_Teams_Drivers_Second] FOREIGN KEY([extSecondDriver])
REFERENCES [dbo].[Drivers] ([id]);