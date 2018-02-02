/*
	Data.........: 01/02/2018
    Descri��o....: Script para inser��o na base de dados Teste
	Arquivo......: 2018-02-01 - Inserts.sql
	Autor........: Ricardo Rinco
*/

use Teste;

-- Estados
insert into Estado (Descricao) values
('Acre'),
('Alagoas'),
('Amazonas'),
('Amap�'),
('Bahia'),
('Cear�'),
('Distrito Federal'),
('Esp�rito Santo'),
('Goi�s'),
('Maranh�o'),
('Minas Gerais'),
('Mato Grosso do Sul'),
('Mato Grosso'),
('Par�'),
('Para�ba'),
('Pernambuco'),
('Piau�'),
('Paran�'),
('Rio de Janeiro'),
('Rio Grande do Norte'),
('Rond�nia'),
('Roraima'),
('Rio Grande do Sul'),
('Santa Catarina'),
('Sergipe'),
('S�o Paulo'),
('Tocantins');

-- Fornecedores
insert Fornecedor (CNPJ, Nome) values
('22608899000162', 'Sococo Distribuidora Aliment�cias'),
('78627601000116', 'Adoro Aliment�cia Coml'),
('83208460000137', 'Ind�stria Aliment�cia do Vale'),
('89416581000150', 'DoGr�o - Alimentos saud�veis'),
('96589575000160', 'Antonella Distribuidora de Alimentos ME'),
('34796137000116', 'TM Distribuidora Aliment�cia LTDA'),
('12538187000160', 'SB ALIMENTOS'),
('92417604000156', 'Azul Distribuidora');