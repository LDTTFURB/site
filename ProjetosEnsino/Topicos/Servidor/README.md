# Servidor

## Permissões

## 2024-09-17 - 15:03

### Acesso SSH

### Acesso Doxcker

Luiz Henrique Martendal (lhmartendal@furb.br)  
Vinícius Estrázulas Mattos (vemattos@furb.br)  
Jorge Guilherme Kohn (jkohn@furb.br)  

Marlon Sbardelatti (msbardelatti@furb.br)  
Emanuel Girardi (esgirardi@furb.br)  
Leonardo Linhares Silva (leonardolinhares@furb.br)  
Felipe Krieger Buche (fbuche@furb.br)  

## Cavala

Pra se conectar, vc pode usar qualquer cliente SSH (por exemplo o Putty). Acho que vc usa o MAC, então deve ter um cliente SSH via linha de comando no terminal dele. De qualquer forma, esses são os dados de conexão:  

### Conectar

![puttyCFG](puttyCFG.png)  

```terminal
> ssh -p 22 dalton@cavala.furb.br  
```

Script pra vc dar acesso aos alunos. Está no seu home da cavala, dentro do diretório scripts:  

> [!IMPORTANT]
> Conectar via VPN antes, caso vc esteja fora da FURB  

### SSH

Conectar à Cavala via SSH (o aluno tem que estar na rede acadêmica interna da FURB) usar script: "/home/FURB/dalton/scripts)":  
[concede_acesso.bash](concede_acesso.bash)  

```terminal
> sudo ./concede_acesso.bash username_do_usuario
```

Tirar a permissão de acesso via SSH:

```terminal
sudo gpasswd -d username_do_usuario ssh_logon
```

### Docker

Permissão total ao docker e seus contêineres, pode usar este comando:  

```terminal
> sudo usermod -a -G docker username_do_usuario
```

Tirar a permissão de acesso ao docker:  

```terminal
> sudo gpasswd -d username_do_usuario docker
```
