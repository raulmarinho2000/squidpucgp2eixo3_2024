# Sistema de Controle de Acesso

## Dependência
* Abaixo estão as dependências para utilizar o programa
  * [squidguard](https://simplificandoredes.com/squidguard-instalacao-e-configuracao/)
  * [dotnet](https://learn.microsoft.com/pt-br/dotnet/core/install/linux-debian)

## Download e Configuração do Webserver

### Faça o download do arquivo .zip no GitHub.

### Adicione o diretório:

Extraia o conteúdo do arquivo .zip para o seguinte diretório:
```
home/usuário/webserver
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