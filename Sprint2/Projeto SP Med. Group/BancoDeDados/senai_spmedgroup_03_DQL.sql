USE SP_Medical_Group


-- CONSULTA --
SELECT NomePaciente,NomeMedico,DataConsulta,Estado FROM Consulta
INNER JOIN Paciente
ON Consulta.idPaciente = Paciente.idPaciente
INNER JOIN Medico
ON Consulta.idMedico = Medico.idMedico
INNER JOIN Situacao
ON Consulta.idSituacao = Situacao.idSituacao

-- Prontuario --
SELECT	NomePaciente,Email,Telefone,RG,CPF,Endereço FROM Paciente
INNER JOIN Usuario
ON Paciente.idUsuario = Usuario.idUsuario

-- Medicos --
SELECT CRM,NomeMedico,Email,Especialidade,NomeFantasia,CNPJ,RazaoSocial,Endereco FROM Medico
INNER JOIN Usuario
ON Medico.idUsuario = Usuario.idUsuario
INNER JOIN Especialidade
ON Medico.idEspecialidade = Especialidade.idEspecialidade
INNER JOIN Clinica
ON Medico.idClinica = Clinica.idClinica

-- Especialidades -- 
SELECT Especialidade FROM Especialidade