using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayListDictionaryExample : MonoBehaviour
{
    [SerializeField] private int[] _number_1 = new int[3];
    [SerializeField] private int[] _number_2 = { 55, 47, 64 }; // сразу инизиализировать массив и задать ему размер
    [SerializeField] private GameObject[] _players;



    [SerializeField] private List<string> _list_1 = new List<string>();



    // Dictionary отличаетс€ от List тем что в нем поиск происходит не по индексу а по ключу
    // Dictionary не отображаетс€ в редакторе в отличии от других переменных
    // Dictionary<keytype, objectType> dictionaryName;
    [SerializeField] private Dictionary<string, int> _dictionary_1 = new Dictionary<string, int>();



    void Start()
    {
        // »нициализировать массив (у которого уже задан размер)
        _number_1[0] = 55;
        _number_1[1] = 47;
        _number_1[2] = 64;



        // инициализовать массив найл€ на сцене все обьекты с нужным тегом
        _players = GameObject.FindGameObjectsWithTag("Player");



        // ƒобавить элементы в список, добавить элемент в нужную часть списка
        _list_1.Add("One");
        _list_1.Add("Two");
        _list_1.Add("Three");
        _list_1.Add("Four");
        _list_1.Add("Five");
        _list_1.Insert(2, "TEST");


        // ƒобавить элементы в словарь разными способами
        _dictionary_1.Add("One", 1);
        _dictionary_1.Add("Two", 2);
        _dictionary_1["Three"] = 3;
        _dictionary_1["Four"] = 4;
        _dictionary_1["Five"] = 5;
    }
}
