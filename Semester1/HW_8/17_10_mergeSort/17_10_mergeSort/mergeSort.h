#pragma once

struct List;

struct Array;

typedef Array Linked;
//typedef List Linked;

// Слияние двух списков в один.
Linked * merge(Linked * linked, Linked * tempLinked);

// Сортировка слиянием.
Linked * mergeSort(Linked * linked);