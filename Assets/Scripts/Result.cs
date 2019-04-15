using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Result
{
    ArrayList results;
    int length;

    public Result()
    {
        results = new ArrayList();
    }

    public Result(ArrayList results)
    {
        this.results = results;
        length = 0;
    }

    public bool HasResult()
    {
        return results.Count > length;
    }

    public void Next()
    {
        length++;
    }

    public string GetString(int index)
    {
        string[] temp=results[length].ToString().Split('\t');
        return temp[index];
    }

    public void Add(String value)
    {
        results.Add(value);
    }

    public int GetLength()
    {
        return results.Count;
    }
}

