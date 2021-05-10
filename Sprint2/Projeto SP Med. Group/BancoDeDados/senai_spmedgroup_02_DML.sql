USE SP_Medical_Group

INSERT INTO TipoUsuario     (NomeTipoUsuario)
VALUES                      ('Administrador'),
                            ('Medico'),
                            ('Paciente');
GO 

INSERT INTO Usuario			(idTipoUsusario,Email,Senha)
VALUES                      (2,'ricardo.lemos@spmedicalgroup.com.br','')
                            ,(2,'roberto.possatle@spmedicalgroup.com.br', '')
                            ,(2,'helena.souza@spmedicalgroup.com.br', '')
                            ,(3,'ligia@gmail.com', '')
                            ,(3,'alexandre@gmail.com', '')
                            ,(3,'fernando@gmail.com', '')
                            ,(3,'henrique@gmail.com', '')
                            ,(3,'joao@hotmail.com', '')
                            ,(3,'bruno@gmail.com', '')
                            ,(3,'mariana@outlook.com', '');
GO

INSERT INTO Paciente		(idUsuario,NomePaciente,DataNascimento,Telefone,RG,CPF,Endereço)
VALUES						(4,'Ligia','1983/10/13','11 3456-7654','43522543-5','94839859000','Rua Estado de Israel 240, São Paulo, Estado de São Paulo, 04022-000')
							,(5,'Alexandre','2001/07/23','11 98765-6543','32654345-7-5','73556944057','Av. Paulista, 1578 - Bela Vista, São Paulo - SP, 01310-200')
                            ,(6,'Fernando','1978/10/10','11 97208-4453','54636525-3','16839338002','Av. Ibirapuera - Indianópolis, 2927,  São Paulo - SP, 04029-200')
                            ,(7,'Henrique','1985/10/13','11 3456-6543','54366362-5','14332654765','R. Vitória, 120 - Vila Sao Jorge, Barueri - SP, 06402-030')
                            ,(8,'João','1975/08/21','11 7656-6377','t32544444-1','91305348010','R. Ver. Geraldo de Camargo, 66 - Santa Luzia, Ribeirão Pires - SP, 09405-380')
                            ,(9,'Bruno','1972/03/27','11 95436-8769','54566266-7','79799299004','Alameda dos Arapanés, 945 - Indianópolis, São Paulo - SP, 04524-001')
                            ,(10,'Mariana','2018/05/03','','54566266-8','13771913039','R Sao Antonio, 232 - Vila Universal, Barueri - SP, 06407-140');
GO

INSERT INTO Especialidade	(NomeEspecialidade)
VALUES						('Acunpuntura')
							,('Anestesiologia')
							,('Angiologia')
							,('Cardiologia')
							,('Cirurgia Cardiovascular')
							,('Cirurgia da Mão')
							,('Cirurgia do Aparelho Digestivo')
							,('Cirurgia Geral')
							,('Cirurgia Pediátrica')
							,('Cirurgia Plástica')
							,('Cirurgia Torácica')
							,('Cirurgia Vascular')
							,('Dermatologista')
							,('Radioterapia')
							,('Urologia')
							,('Pediatria')
							,('Psiquiatria');
GO

INSERT INTO Clinica			(Endereco,CNPJ,NomeFantasia,RazaoSocial)
VALUES						('Av. Barão Limeira, 532, São Paulo, SP','86.400.902/0001-30','Clinica Possarle ','SP Medical Group');
GO

INSERT INTO Medico			(idUsuario,idClinica,idEspecialidade,NomeMedico,CRM)
VALUES						(1,1,1,'Ricardo Lemos','54356-SP')
							,(2,1,17,'Roberto Possarle','53452-SP')
							,(3,1,16,'Helena Strada','65463-SP');
GO

INSERT INTO Situacao		(Estado)
VALUES						('Agendada')
							,('Realizada')
							,('Cancelada');
GO

INSERT INTO Consulta		(idPaciente,idMedico,idSituacao,DataConsulta)
VALUES						(7,3,2,'2020-01-20T15:00:00')
							,(2,2,3,'2020-01-06T10:00:00')
							,(3,2,2,'2020-02-07T11:00:00')
							,(2,2,2,'2020-02-06T10:00:00')
							,(4,1,3,'2020-02-07T11:00:00')
							,(7,3,1,'2020-03-08T15:00:00')
							,(4,1,1,'2020-03-09T11:00:00');
GO

