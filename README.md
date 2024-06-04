# Sistema de Controle de Acesso

## Dependência
* Abaixo estão as dependências para utilizar o programa
  * [squidguard](https://simplificandoredes.com/squidguard-instalacao-e-configuracao/)
  * [dotnet](https://learn.microsoft.com/pt-br/dotnet/core/install/linux-debian)

## Download e Configuração do Webserver

### Utilize o Git Clone para clonar o repositório
```
cd resources
gh repo clone raulmarinho2000/squidpucgp2eixo3_2024
```

### Substitua a pasta `webserver` existente pela pasta extraída do arquivo .zip.


## Iniciando o Webserver

Para iniciar o webserver, siga os seguintes passos:

1. **Abra um terminal.**
2. **Navegue até o diretório `webserver`:**
   ```bash
   cd home/usuário/webserver

3. **Execute o comando:**

```
dotnet run
```

### Acessando a Interface do Webserver

1. **Abra um navegador web.**
2. **Na barra de URL, digite o endereço:**

```
localhost:5176
```

* Nota: A porta padrão é `5176`.


### Adicionando Regras de Bloqueio de URLs

1. **Na interface do webserver, localize o campo "URL".**

2. **Adicione o endereço que deseja bloquear ou liberar o acesso.**
3. **Na opção "Ação":**
Escolha se deseja adicionar ou remover o URL da blacklist.

4. **Clique em "Enviar"**.

### Verificando URLs na Blacklist

Para verificar se o URL foi adicionado corretamente ao arquivo de blacklist, siga os seguintes passos:

1. **No terminal, digite o comando:**

```
nano /var/lib/squidguard/db/hep/block_domain
```

2. **Será aberto o arquivo e nele você poderá visualizar todos os domínios que foram adicionados.**

Siga estes passos para garantir que o webserver está configurado corretamente e que os URLs estão sendo gerenciados conforme necessário.

## Como o projeto impactou o cliente?

A solução apresentada é uma excelente possível ferramenta a ser implementada nas filiais da empresa, visto que a matriz já possui um serviço similar e as filiais não possuem nenhum serviço de controle de acessos. Nosso projeto causou no cliente a percepção de uma alternativa de implementação de serviço de controle de acessos de forma mais simples e eficaz.

## Como o desenvolvimento do projeto impactou na formação do grupo?

O desenvolvimento do projeto ampliou nossos conhecimentos na área de infraestrutura e segurança de rede, nos possibilitando desenvolver habilidades em manuseio de sistemas operacionais Linux via Terminal, configuração de Proxy Server e manipulação via ShellScript/Dotnet.

## Registro visual da reunião com o cliente

