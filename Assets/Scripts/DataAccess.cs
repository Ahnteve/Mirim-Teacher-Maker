using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataAccess : MonoBehaviour {
    private TextAsset data;

    private static DataAccess instance;

    public static DataAccess Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<DataAccess>();
                // DataController를 찾아 할당

                if (instance == null)
                {
                    // 그래도 없으면 DataController를 생성
                    GameObject container = new GameObject();
                    instance = container.AddComponent<DataAccess>();
                }
            }
            return instance;
        }
    }

    public Result Select(string fileName, string feild, string value)
    {
        ArrayList results = new ArrayList();
        StreamReader sr = new StreamReader(Application.dataPath + "/Resources/Data/" + fileName);

        string[] values;
        string source = sr.ReadLine();
        
        values = source.Split('\t');
        int index=0;

        for (int i = 0; i < values.Length; i++)
        {
            if (values[i].Equals(feild))
            {
                index = i;
                break;
            }
        }

        while (true)
        {
            source = sr.ReadLine();

            if (source == null) break;
            values = source.Split('\t');
            if (values[index].Equals(value))
            {
                results.Add(source);
            }

        }
        sr.Close();

        Result r = new Result(results);

        return r;
    }

    public Result SelectAll(string fileName)
    {
        ArrayList results = new ArrayList();
        data = Resources.Load("Data/" + fileName, typeof(TextAsset)) as TextAsset;
        StringReader sr = new StringReader(data.text);

        string source = sr.ReadLine();
        
        while (true)
        {
            source = sr.ReadLine();
            if (source == null) break;
            results.Add(source);
            //Debug.Log(source);

        }
        sr.Close();

        Result r = new Result(results);

        return r;
    }

}