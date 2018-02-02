/*
	Data.........: 01/02/2018
    Descrição....: Script para inserção na base de dados Teste
	Arquivo......: 2018-02-01 - Inserts.sql
	Autor........: Ricardo Rinco
*/

use Teste;

-- Estados
insert into Estado (Descricao) values
('Acre'),
('Alagoas'),
('Amazonas'),
('Amapá'),
('Bahia'),
('Ceará'),
('Distrito Federal'),
('Espírito Santo'),
('Goiás'),
('Maranhão'),
('Minas Gerais'),
('Mato Grosso do Sul'),
('Mato Grosso'),
('Pará'),
('Paraíba'),
('Pernambuco'),
('Piauí'),
('Paraná'),
('Rio de Janeiro'),
('Rio Grande do Norte'),
('Rondônia'),
('Roraima'),
('Rio Grande do Sul'),
('Santa Catarina'),
('Sergipe'),
('São Paulo'),
('Tocantins');

-- Fornecedores
insert Fornecedor (CNPJ, Nome) values
('22608899000162', 'Sococo Distribuidora Alimentícias'),
('78627601000116', 'Adoro Alimentícia Coml'),
('83208460000137', 'Indústria Alimentícia do Vale'),
('89416581000150', 'DoGrão - Alimentos saudáveis'),
('96589575000160', 'Antonella Distribuidora de Alimentos ME'),
('34796137000116', 'TM Distribuidora Alimentícia LTDA'),
('12538187000160', 'SB ALIMENTOS'),
('92417604000156', 'Azul Distribuidora');