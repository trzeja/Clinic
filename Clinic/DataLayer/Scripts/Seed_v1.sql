USE [clinic]
GO
INSERT [dbo].[User] ([user_name], [password], [retire_date], [roles], [lname], [fname]) VALUES (N'admin', N'21232F297A57A5A743894A0E4A801FC3', NULL, N'ADM', N'Wiśniewski', N'Tomasz')
GO
INSERT [dbo].[User] ([user_name], [password], [retire_date], [roles], [lname], [fname]) VALUES (N'doc', N'9A09B4DFDA82E3E665E31092D1C3EC8D', NULL, N'DOC', N'Nowak', N'Jan')
GO
INSERT [dbo].[User] ([user_name], [password], [retire_date], [roles], [lname], [fname]) VALUES (N'doc1', N'83E4B1789306D3D1C99140DF3827D600', NULL, N'DOC', N'Myśliński', N'Grzegorz')
GO
INSERT [dbo].[User] ([user_name], [password], [retire_date], [roles], [lname], [fname]) VALUES (N'labm', N'9A1DAC53DCCF75E2F9407C4FD16E51CF', NULL, N'LABM', N'Doborowski', N'Krzysztof')
GO
INSERT [dbo].[User] ([user_name], [password], [retire_date], [roles], [lname], [fname]) VALUES (N'labm1', N'E7A60B20E689B91C981137E58B8659EB', NULL, N'LABM', N'Zaborowski', N'Henryk')
GO
INSERT [dbo].[User] ([user_name], [password], [retire_date], [roles], [lname], [fname]) VALUES (N'labw', N'F8173FDF26441431ED158E9212B4BD14', NULL, N'LABW', N'Wesołowski', N'Wojciech')
GO
INSERT [dbo].[User] ([user_name], [password], [retire_date], [roles], [lname], [fname]) VALUES (N'labw1', N'9EE96306CE898A1168B350A07B581869', NULL, N'LABW', N'Czapla', N'Zbigniew')
GO
INSERT [dbo].[User] ([user_name], [password], [retire_date], [roles], [lname], [fname]) VALUES (N'reg', N'33C0EE425E2C0EFE834AFC1AA1E33A4C', NULL, N'REG', N'Zielińska', N'Jolanta')
GO
INSERT [dbo].[User] ([user_name], [password], [retire_date], [roles], [lname], [fname]) VALUES (N'reg1', N'B37433910BCB25E4F6A875A54A0E6394', NULL, N'REG', N'Myszorowska', N'Anna')
GO
SET IDENTITY_INSERT [dbo].[Doctor] ON 

GO
INSERT [dbo].[Doctor] ([id_doc], [medical_right_no], [user_name]) VALUES (1, N'123123', N'doc')
GO
INSERT [dbo].[Doctor] ([id_doc], [medical_right_no], [user_name]) VALUES (2, N'43234', N'doc1')
GO
SET IDENTITY_INSERT [dbo].[Doctor] OFF
GO
SET IDENTITY_INSERT [dbo].[Patient] ON 

GO
INSERT [dbo].[Patient] ([id_patient], [fname], [lname], [PESEL]) VALUES (1, N'Krzysztof', N'Kaczmarczyk', N'12345678901')
GO
INSERT [dbo].[Patient] ([id_patient], [fname], [lname], [PESEL]) VALUES (2, N'Paweł', N'Gruźliński', N'98765432101')
GO
SET IDENTITY_INSERT [dbo].[Patient] OFF
GO
SET IDENTITY_INSERT [dbo].[Registration] ON 

GO
INSERT [dbo].[Registration] ([id_registration], [user_name]) VALUES (1, N'reg')
GO
INSERT [dbo].[Registration] ([id_registration], [user_name]) VALUES (2, N'reg1')
GO
SET IDENTITY_INSERT [dbo].[Registration] OFF
GO
SET IDENTITY_INSERT [dbo].[Visit] ON 

GO
INSERT [dbo].[Visit] ([id_visit], [description], [diagnosis], [state], [registration_date], [execution_cancel_datetime], [id_patient], [id_registration], [id_doctor]) VALUES (1, NULL, NULL, N'REG', CAST(N'2017-09-22T09:15:00.000' AS DateTime), NULL, 1, 1, 1)
GO
INSERT [dbo].[Visit] ([id_visit], [description], [diagnosis], [state], [registration_date], [execution_cancel_datetime], [id_patient], [id_registration], [id_doctor]) VALUES (2, NULL, NULL, N'REG', CAST(N'2017-09-30T08:25:00.000' AS DateTime), NULL, 1, 1, 2)
GO
INSERT [dbo].[Visit] ([id_visit], [description], [diagnosis], [state], [registration_date], [execution_cancel_datetime], [id_patient], [id_registration], [id_doctor]) VALUES (3, NULL, NULL, N'REG', CAST(N'2017-09-20T09:30:00.000' AS DateTime), NULL, 2, 1, 2)
GO
INSERT [dbo].[Visit] ([id_visit], [description], [diagnosis], [state], [registration_date], [execution_cancel_datetime], [id_patient], [id_registration], [id_doctor]) VALUES (4, NULL, NULL, N'REG', CAST(N'2017-09-20T11:35:00.000' AS DateTime), NULL, 2, 1, 1)
GO
INSERT [dbo].[Visit] ([id_visit], [description], [diagnosis], [state], [registration_date], [execution_cancel_datetime], [id_patient], [id_registration], [id_doctor]) VALUES (5, NULL, NULL, N'REG', CAST(N'2017-09-06T08:30:00.000' AS DateTime), NULL, 2, 1, 1)
GO
INSERT [dbo].[Visit] ([id_visit], [description], [diagnosis], [state], [registration_date], [execution_cancel_datetime], [id_patient], [id_registration], [id_doctor]) VALUES (6, NULL, NULL, N'REG', CAST(N'2017-09-20T08:15:00.000' AS DateTime), NULL, 1, 1, 2)
GO
SET IDENTITY_INSERT [dbo].[Visit] OFF
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'89.11', N'P', N'Tonometria')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'89.12', N'P', N'	Badanie funkcji nosa')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'89.17', N'P', N'Polisomnografia')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'89.22', N'P', N'Cystometrogram')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'89.41', N'P', N'	Badanie wysiłkowe serca na bieżni ruchomej')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'89.46', N'P', N'Sprawdzenie kształtu impulsu rozrusznik')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'89.51', N'P', N'Elektrokardiogram (ocena rytmu serca)')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'89.56', N'P', N'	Zapis tętna tętnicy szyjnej (z ekg) - sfigmokardiogram')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'89.58', N'P', N'Pletyzmogram')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'89.64', N'P', N'	Monitorowanie ciśnienia zaklinowania w tętnicy płucnej')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'89.79', N'P', N'	Badanie fizykalne - inne')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'A15', N'L', N'Glukoza w moczu')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'C30', N'L', N'Leukocyty - liczba')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'E05', N'L', N'Badanie w kierunku nieregularnych przeciwciał')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'F36', N'L', N'Rotavirus Antygen')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'G19', N'L', N'Czas krzepnięcia pełnej krwi')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'I33', N'L', N'Androsteron')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'K09', N'L', N'Chymotrypsyna')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'L83', N'L', N'	Hydroksyprolina')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'M22', N'L', N'Kinaza glicerolowa')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'N51', N'L', N'Pregnantriol')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'O12', N'L', N'	Identyfikacja alloprzeciwciał')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'P33', N'L', N'Fenol')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'R03', N'L', N'Trójchlorooctowy kwas')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'S33', N'L', N'Borrelia afzelli Przeciwciała IgG')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'T25', N'L', N'Fenobarbital')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'V14', N'L', N'Wirus RS Antygen')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'W27', N'L', N'	Candida albicans Przeciwciała')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'X21', N'L', N'	Leishmania Antygen')
GO
INSERT [dbo].[Examination_dictionary] ([code], [type], [name]) VALUES (N'Y90', N'L', N'Badanie histopatologiczne')
GO
SET IDENTITY_INSERT [dbo].[Laboratory_manager] ON 

GO
INSERT [dbo].[Laboratory_manager] ([id_laboratory_manager], [user_name]) VALUES (1, N'labm')
GO
INSERT [dbo].[Laboratory_manager] ([id_laboratory_manager], [user_name]) VALUES (2, N'labm1')
GO
SET IDENTITY_INSERT [dbo].[Laboratory_manager] OFF
GO
SET IDENTITY_INSERT [dbo].[Laboratory_worker] ON 

GO
INSERT [dbo].[Laboratory_worker] ([id_laboratory_worker], [user_name]) VALUES (1, N'labw')
GO
INSERT [dbo].[Laboratory_worker] ([id_laboratory_worker], [user_name]) VALUES (2, N'labw1')
GO
SET IDENTITY_INSERT [dbo].[Laboratory_worker] OFF
GO
SET IDENTITY_INSERT [dbo].[Address] ON 

GO
INSERT [dbo].[Address] ([id_patient], [place], [street], [zip_code], [house], [flat]) VALUES (1, N'Warszawa', N'Polna', N'34-123', N'5', N'')
GO
INSERT [dbo].[Address] ([id_patient], [place], [street], [zip_code], [house], [flat]) VALUES (2, N'Kołobrzeg', N'Wiejska', N'54-533', N'8', N'7')
GO
SET IDENTITY_INSERT [dbo].[Address] OFF
GO
