# Projeto de API com dados do IBGE.

Esse projeto tem como objetivo disponibilizar o acesso à dados públicos do IBGE via API.  

## Instruções:
- Para os tipos de rota Create, Update e Delete é **obrigatória** autenticação do usuário.
- O token de autenticação deve ser gerado através da rota de criação de usuário.
- O token expira em 12 horas e é possível gerar um novo token através da rota de login.
- As rotas do tipo GET são públicas e não precisam de autorização para acesso.

## Rotas IBGE disponíveis:
### Create
	Recebe um JSON com dados do IBGE (cidade e estado) e cria um novo registro.  
	Retorna o registro com os dados criados.

### GetById/:id
	Retorna o objeto com os dados do registro passado na url da requisição.

### GetByCity/:city
	Retorna o objeto ou uma lista com as cidades correspondentes ao nome passado na url.

### GetByState/:state
	Retorna uma lista com todas as cidades do estado passado na url.

### Update/:id
	Recebe um JSON do tipo IBGE e atualiza os dados do registro cujo ID corresponde ao da URL.  
	Retorna o registro modificado.

### Delete/:id
	Remove o registro enviado na URL do banco de dados da aplicação.

## Rotas de Login

### Create
	Recebe um email e uma senha e grava esses registros no banco de dados.  
	Retorna um objeto com os dados do usuário criado e um token de acesso.

### Login
	Recebe um objeto com email e senha existentes e retorna os dados do usuário com o token.

# Desenvolvedores
[@jefersonquaiato](https://github.com/jefersonquaiato), 
[@teixeiralex](https://github.com/teixeiralex) e
[@victorschlindwein](https://github.com/victorschlindwein)  