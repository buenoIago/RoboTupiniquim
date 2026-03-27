# ROBÔ TUPINIQUIM

## 🤖 INTRODUÇÃO
Este simulador de movimentação foi desenvolvido em C# para operar via Console. O objetivo é controlar um robô em uma grade lógica, permitindo que ele se posicione e execute comandos de exploração em um plano cartesiano. O sistema processa coordenadas geográficas e orientações (Norte, Sul, Leste, Oeste) para determinar a localização exata do robô após uma série de instruções.

Desenvolvido por Iago na Academia do Programador.

## FUNCIONALIDADES
* Interface de configuração de posição inicial $(X, Y)$.
* Sistema de orientação por pontos cardeais $(N, S, L, O)$.
* Processamento de strings de comando para movimentação.
* Tratamento de entradas do usuário (conversão de texto para char e int).
* Validação de comandos (transformação de letras minúsculas em maiúsculas).Arquitetura modular com separação entre lógica (Robo.cs) e execução (Program.cs).
* Exibição em tempo real do status e localização do robô.Suporte a múltiplos comandos em uma única linha de instrução.

## Como utilizar o programa

1. Clone o repositório ou baixe o código comprimido em .zip.
2. Abra o emulador de terminal e navegue até a pasta raiz.
3. Utilize o comando abaixo para restaurar as dependências do projeto.

     ```
     dotnet restore
     ```

4. Em seguida compile e execute o projeto com o comando: 

    ```
    dotnet run --project RoboTupiniquim.Console.App
    ```

## Requistitos

* .NET SDK 10.0