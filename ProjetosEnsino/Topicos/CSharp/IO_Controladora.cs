using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityAndroidOpenUrl;
using UnityEngine.Android;
using Unity.Profiling;
public class IO_Controladora : MonoBehaviour
{
    public Button botaoAbrir, botaoEnviar, botaoFix;
    public GameManager gerenteDente = new GameManager();
    string UrlCsvRoot, UrlCsvFile, UrlCsvArquivo,//@Root=PersistentDataPath; @File =@Root/Files; @Arquivo = @File/Nome.csv ou @Root/Files/Nome.csv
    dataType = "application/csv"; //Tipo de documento. Usado com UrlCsvArquivo

    //Profiler:
    ProfilerMarker comecoOpen = new ProfilerMarker("Open CPU USAGE");
    void Start()
    {
        definirPathArquivos();
        integridadeArquivos(); //Verifica se o diretório existe e não retorna até existirem

        comecoOpen.Begin();
        //Definir Funções botão:
        botaoAbrir.onClick.AddListener(delegate ()
        {
            abrirArquivo();
            Debug.LogWarning("O Local do arquivo é: " + UrlCsvArquivo);
        });

        botaoEnviar.onClick.AddListener(delegate ()
        {
            incrementarTexto();
            Debug.LogWarning("O Arquivo a ser incrementado é: " + UrlCsvArquivo);
            
        });

        botaoFix.onClick.AddListener(delegate ()
        {
            definirPathArquivos();
            integridadeArquivos(); //Verifica se o diretório existe e não retorna até existirem
        });

    }

    public void definirPathArquivos()
    {
        UrlCsvRoot = Application.persistentDataPath; //Define diretório base
        UrlCsvFile = UrlCsvRoot + "/File"; //Define o diretório da pasta com os arquivos
        UrlCsvArquivo = UrlCsvFile + "/teste.csv"; //Define o diretório indexado com o arquivo csv
        Debug.Log("UrlCsvRoot: " + UrlCsvRoot + " UrLCsvFile: " + UrlCsvFile + " UrlCsvArquivo: " + UrlCsvArquivo);
    }

    public void pegarEstado()
    {
        for(int i = 0; i < 32; i++)
        {
            Debug.Log(gerenteDente._TeethsType[i]);
        }
    }


    public void abrirArquivo()
    {
        AndroidOpenUrl.OpenFile(UrlCsvArquivo, dataType);
        comecoOpen.End();
    }

    public void integridadeArquivos()
    {
        Debug.Log("UrlCsvRoot: " + UrlCsvRoot + " UrLCsvFile: " + UrlCsvFile + " UrlCsvArquivo: " + UrlCsvArquivo);
        //Verifica se o aplicativo tem permissão para atuar com arquivos:
        if (Permission.HasUserAuthorizedPermission(Permission.ExternalStorageRead))
        {
            Permission.RequestUserPermission(Permission.ExternalStorageRead);
        }
        if(Permission.HasUserAuthorizedPermission(Permission.ExternalStorageWrite))
        {
            Permission.RequestUserPermission(Permission.ExternalStorageWrite);
        }

        //Com devida autorização, fica tentando criar os arquivos
        if (!File.Exists(UrlCsvFile)) //Enqanto o diretório com a pasta não existe:
        {
            Directory.CreateDirectory(UrlCsvFile); //Se não existe, cria-o
        }
        if (!File.Exists(UrlCsvArquivo))
        {
            File.WriteAllText(UrlCsvArquivo," ;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16;17;18;19;20;21;22;23;24;25;26;27;28;29;30;31;32 \n");
        }
    }

    public void incrementarTexto()
    {
        string dadosDenteIterar="";
        for(int i = 0; i < gerenteDente._TeethsType.Length; i++ )
        {
            dadosDenteIterar += gerenteDente._TeethsType[i] + "; ";
        }
        File.AppendAllText(UrlCsvArquivo, " ;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16;17;18;19;20;21;22;23;24;25;26;27;28;29;30;31;32 \n" + Time.deltaTime + "; " + dadosDenteIterar + " \n");
        Debug.LogWarning("O Texto a ser implantado é " + " ;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16;17;18;19;20;21;22;23;24;25;26;27;28;29;30;31;32 \n" + Time.deltaTime + "; " + dadosDenteIterar + " \n");
    }
}
