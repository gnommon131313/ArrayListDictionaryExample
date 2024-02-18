using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayListDictionaryExample : MonoBehaviour
{
    [SerializeField] private int[] _number_1 = new int[3];
    [SerializeField] private int[] _number_2 = { 55, 47, 64 }; // ����� ���������������� ������ � ������ ��� ������
    [SerializeField] private GameObject[] _players;



    [SerializeField] private List<string> _list_1 = new List<string>();



    // Dictionary ���������� �� List ��� ��� � ��� ����� ���������� �� �� ������� � �� �����
    // Dictionary �� ������������ � ��������� � ������� �� ������ ����������
    // Dictionary<keytype, objectType> dictionaryName;
    [SerializeField] private Dictionary<string, int> _dictionary_1 = new Dictionary<string, int>();



    void Start()
    {
        // ���������������� ������ (� �������� ��� ����� ������)
        _number_1[0] = 55;
        _number_1[1] = 47;
        _number_1[2] = 64;



        // �������������� ������ ����� �� ����� ��� ������� � ������ �����
        _players = GameObject.FindGameObjectsWithTag("Player");



        // �������� �������� � ������, �������� ������� � ������ ����� ������
        _list_1.Add("One");
        _list_1.Add("Two");
        _list_1.Add("Three");
        _list_1.Add("Four");
        _list_1.Add("Five");
        _list_1.Insert(2, "TEST");


        // �������� �������� � ������� ������� ���������
        _dictionary_1.Add("One", 1);
        _dictionary_1.Add("Two", 2);
        _dictionary_1["Three"] = 3;
        _dictionary_1["Four"] = 4;
        _dictionary_1["Five"] = 5;
    }
}
