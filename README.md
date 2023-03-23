# Sistema de Enxoval de Bebe

## Projeto
O projeto tem como objetivo auxiliar as mulheres grávidas com o inventário do enxoval de seu bebê. Existirá uma lista pronta padronizada com a descrição do tipo de vestuário / item, tamanho e a quantidade ideal para se adquirir. Durante a montagem do enxoval, a usuária irá    cadastrar as peças obtidas e o sistema irá mostrar o status se para aquele item já foi obtido o que foi estabelecido como ideal ou se é necessario a obtenção de mais itens daquele tipo e tamanho.

## Tecnologia
Será desenvolvido em .NET com o design pattern MVC e com armazenamento SQL Server

## Requisitos

### Cadastro da usuária
Este dados servirá para o futuro login e contemplará os seguintes dados:
Nome completo*
Senha*
Email*
Nome do bebê
Sexo do bebê
Data prevista para o nascimento*


### Validação do cadastro:
Todos os campos com o * (asterisco), deve ser obrigatório.
* Email: Deve ter um email válido.
* Email: Não permitirá um email já cadastrado.
* Nome completo: Não pode ter menos que 5 caracteres.
* Data prevista para o nascimento: Não pode ser menor que a data corrente.
* Login, será resgatado os dados de acesso Email e Senha, se os dados estiverem corretamente, será redirecionada para a tela do enxoval, senão, irá manter na tela de login.

### Tela enxoval
Carregar uma lista pronta para quando a usuária inserir em cada peça a quantidade que ela já possui e irá aparecer os seguintes status:
* Vermelho: Quando não atingiu a quantidade necessária.
* Verde: Quando atingir a quantidade necessária.
* Azul: Quando ultrapassar a quantidade necessária.
