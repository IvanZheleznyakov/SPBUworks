#pragma once

struct List;

struct Array;

typedef Array Linked;
//typedef List Linked;

// ������� ���� ������� � ����.
Linked * merge(Linked * linked, Linked * tempLinked);

// ���������� ��������.
Linked * mergeSort(Linked * linked);