#!/bin/bash

GRUPO_SSH=ssh_logon
GRUPO="domain users"

# Função para imprimir mensagens de erro e sair
error_exit() {
    echo "$1" >&2
    exit 1
}

# Verificar se um nome de usuário foi fornecido
if [ $# -ne 1 ]; then
    error_exit "Uso: $0 <nome_do_usuario>"
fi

USERNAME=$1

# Verificar se o usuário existe
echo -n "Verificando se o usuário existe. Isso pode demorar um pouco...: "
id -u "$USERNAME" &>/dev/null
if [ $? -ne 0 ]; then
	texto="Erro!"
	echo -e "\033[0;31m${texto}\033[0m"
    error_exit "O usuário '$USERNAME' não existe."
fi
texto="OK."
echo -e "\033[0;32m${texto}\033[0m"

# Adiciona o usuário ao grupo que permite logon via SSH
echo -n "Adicionando usuário ao grupo ${GRUPO_SSH}: "
usermod -a -G "$GRUPO_SSH" "$USERNAME" &>/dev/null
if [ $? -ne 0 ]; then
	texto="Erro!"
	echo -e "\033[0;31m${texto}\033[0m"
    error_exit "Falha ao adicionar usuário ao grupo ${GRUPO_SSH}."
fi
texto="OK."
echo -e "\033[0;32m${texto}\033[0m"

# Criar diretório home do usuário
echo -n "Criando diretório home: "
mkdir -m 700 /home/FURB/${USERNAME} &>/dev/null
if [ $? -ne 0 ]; then
	texto="Erro!"
	echo -e "\033[0;31m${texto}\033[0m"
    error_exit "Falha ao criar home do usuário."
fi
texto="OK."
echo -e "\033[0;32m${texto}\033[0m"

# Corrigindo owner do diretório
echo -n "Corrigindo owner do home. Isso pode demorar um pouco...: "
chown ${USERNAME}."${GRUPO}" /home/FURB/${USERNAME} &>/dev/null
if [ $? -ne 0 ]; then
	texto="Erro!"
	echo -e "\033[0;31m${texto}\033[0m"
    error_exit "Falha ao criar home do usuário."
fi
texto="OK."
echo -e "\033[0;32m${texto}\033[0m"

