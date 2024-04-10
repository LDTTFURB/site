# GitHubFork

## Pegar alterações do GitHub de um Fork

1) Source Control / Branch / Merge Branch...  
  Select a branch to merge from  
    origin/main origin/main  
2) Source Control / Pull,Push / Pull from...  
  Pick a remote to pull the branch from  
    upstream https://github.com/user_name/git_name.git  


Pesquisar mais
Usei <https://docs.github.com/pt/github/collaborating-with-pull-requests/working-with-forks/syncing-a-fork>

e funcionou.

$ git fetch upstream
$ git checkout main
$ git merge upstream/main

Acho que este é o processo contrário
<https://docs.github.com/pt/github/collaborating-with-pull-requests/working-with-forks/merging-an-upstream-repository-into-your-fork>

Ver image, e fazer algum para os alunos e TCCs:
<https://medium.com/@sahoosunilkumar/how-to-update-a-fork-in-git-95a7daadc14e>

