## Samuel Monai
<span> Projeto de formatação rápida DUW e DUS </span>

## Aprendizados
Este projeto implementa um bot em C# que realiza conexões via porta serial com equipamentos DUW ou DUS. O bot 
envia comandos específicos para o equipamento, como `reload`, `mount_c2`, e formatação de 
partições, dependendo do tipo de equipamento (DUW ou DUS). Ele também aguarda por prompts do 
sistema para confirmações de formatação e realiza as ações com base nas respostas do usuário.

<span>Pinagens para configuração do cabo.</span>

##  DUW-3001 e 3101
| RJ45  | DB-9  |
| ----- | ----- |
|   1   |   5   |
|   2   |   3   |
|   3   |   2   |
|   4   |   7   |
|   5   |   8   |

##  DUS e DUW-4101
| RJ45  | DB-9  |
| ----- | ----- |
|   3   |   4   |
|   4   |   7   |
|   5   |   5   |


## Funcionalidades

- Conecta-se a dispositivos via porta serial.
- Executa comandos específicos de acordo com o tipo de equipamento: DUW ou DUS.
- Aguarda por solicitações de confirmação do sistema (como formatação de partições) e permite ao usuário responder.
- Configura o IP do dispositivo após a execução dos comandos.

## Tecnologias Utilizadas

- **Linguagem**: C#
- **Framework**: .NET Core
- **Comunicação Serial**: `System.IO.Ports`

## Pré-requisitos

- .NET Core SDK (versão 6.0 ou superior)
- Porta serial configurada e conectada ao equipamento com cabo RJ45/DB9 - conversor Serial-USB.
- Programa pre-configurado com COM3.


##
<div align="center">Feito por <a href="https://samuelmonai.com.br>Perfil</a>.</div>

