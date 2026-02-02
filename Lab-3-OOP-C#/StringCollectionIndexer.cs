using System;

class StringCollectionIndexer
{ 
    private string[] items = new string[10];

    private string[] keys = new string[10];
    private string[] values = new string[10];
    private int count = 0;

    //? Integer indexer For setting and getting values
    public string this[int index]
    {
        get { return items[index]; }
        set { items[index] = value; }
    }

    //? String indexer for setting and getting keys
    public string this[string key]
    {
        get { return FindByKey(key); }
        set { SetByKey(key, value); }
    }

    private string FindByKey(string key)
    {
        for (int i = 0; i < count; i++)
        {
            if (keys[i] == key)
                return values[i];
        }
        return null;
    }

    private void SetByKey(string key, string value)
    {
        for (int i = 0; i < count; i++)
        {
            if (keys[i] == key)
            {
                values[i] = value;
                return;
            }
        }

        keys[count] = key;
        values[count] = value;
        count++;
    }
}
