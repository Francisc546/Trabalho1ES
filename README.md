
# Trabalho1ES

Neste trabalho criei 5 classes: Animal, Cliente, Servicos, Funcionario e Clinica.

A classe Animal tem como atributos: nome (string), idade (int), genero (string), especie (string) e id (int).
A classe Cliente tem como atributos: nome (string), contacto (string) e endereco (string) que são declarados na sua criação depois tem uma lista de consultas (string) e outra de serviços (Servicos) e tem ainda a frequência (int).
A classe Servicos tem como atributos: nome(string), preco (double), duracao (double) e medicamentos (string).
A classe Funcionario tem como atributos: nome (string) e disponibilidade de horario (string).
A classe Clinica serve para guardar todas as instaciâncias das outras 4 classes (Animal, Cliente, Servicos e Funcionario), por isso só possui uma lista para cada uma das 4 classes.


Ao correr a aplicação temos estas 10 opções:

![Menu Clinica](https://user-images.githubusercontent.com/49655530/114287935-2948aa80-9a63-11eb-82c9-ffb38e11e0aa.jpg)

Ao escolhermos a 1ª opção ele imprime os servicos disponibilizados pela clinica: 

![Opcao1](https://user-images.githubusercontent.com/49655530/114287969-5e54fd00-9a63-11eb-96f2-1ff91fb94af5.jpg)

Ao escolhermos a 2ª opção ele imprime os funcionarios da clinica e disponibilidade de horario

![opcao2](https://user-images.githubusercontent.com/49655530/114287992-8ba1ab00-9a63-11eb-8018-0e778c4fc102.jpg)

Ao escolhermos a 3ª opção ele imprime a lista dos clientes e pede qual o número do cliente que queremos o relatório
![opcao3 1](https://user-images.githubusercontent.com/49655530/114288034-ee934200-9a63-11eb-84b8-d64ee6384312.jpg)

Neste caso só temos 1 cliente registado por isso escrevi o número desse cliente mas como ainda não tinhamos adicionado nenhuma consulta, frequência ou serviço ao cliente ele só tem as informações básicas preenchidas no relatório
![opcao3 2](https://user-images.githubusercontent.com/49655530/114288077-35813780-9a64-11eb-9f52-e528d1a905f8.jpg)

Portanto vamos usar a 5ª opção e depois voltar a gerir o relatório
Ao escolhermos a 5ª opção voltamos a ter os clientes para selecionar

![image](https://user-images.githubusercontent.com/49655530/114288100-724d2e80-9a64-11eb-85ec-bd26e375262e.png)

Depois de selecionarmos o cliente desejado preenchemos a informação sobre a consulta, frequência e nos servicos imprime os serviços disponíveis com uma numeração para selecionarmos qual dos serviços foi prestado

![image](https://user-images.githubusercontent.com/49655530/114288148-c5bf7c80-9a64-11eb-8f12-557e938852ac.png)

Agora voltando a repetir a 3ª opção e selecionando o mesmo cliente apresenta-nos o seguinte

![image](https://user-images.githubusercontent.com/49655530/114288164-e091f100-9a64-11eb-99a3-4845e781ca64.png)


A 4ª, 6ª, 7ª e 9ª opção são semelhantes variando apenas os dados que são pedidos para a criação de uma nova instância da classe da opção
Opção 4:
![image](https://user-images.githubusercontent.com/49655530/114288235-bbea4900-9a65-11eb-91fe-06afbb11d877.png)

Opção 6ª:
![image](https://user-images.githubusercontent.com/49655530/114288241-cb699200-9a65-11eb-9c1d-5a64538644e4.png)

Opção 7:
![image](https://user-images.githubusercontent.com/49655530/114288247-e63c0680-9a65-11eb-8161-b7de9ab3a4b8.png)

Opção 9:
![image](https://user-images.githubusercontent.com/49655530/114288254-f48a2280-9a65-11eb-9efe-9d50389e7438.png)


A 8ª opção imprime os animais registados na clinica

![image](https://user-images.githubusercontent.com/49655530/114288268-11265a80-9a66-11eb-9095-45043046af0d.png)

Por último a 10ª opção fecha o programa
