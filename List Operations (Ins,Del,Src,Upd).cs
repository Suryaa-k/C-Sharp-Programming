using System;

class Program {
    static int[] list = new int[10];
    static int size = 0;

    static void Insert(int index, int value) {
        if (size >= list.Length || index < 0 || index > size) return;
        for (int i = size; i > index; i--) {
            list[i] = list[i - 1];
        }
        list[index] = value;
        size++;
    }

    static void DeleteAt(int index) {
        if (index < 0 || index >= size) return;
        for (int i = index; i < size - 1; i++) {
            list[i] = list[i + 1];
        }
        size--;
    }

    static int Search(int value) {
        for (int i = 0; i < size; i++) {
            if (list[i] == value) return i;
        }
        return -1;
    }

    static void Update(int index, int value) {
        if (index < 0 || index >= size) return;
        list[index] = value;
    }

    static void Traverse() {
        for (int i = 0; i < size; i++) {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main() {
        Insert(0, 10);
        Insert(1, 20);
        Insert(2, 30);
        Traverse();

        Insert(1, 15);
        Traverse();

        DeleteAt(2);
        Traverse();

        Update(0, 99);
        Traverse();

        Console.WriteLine("Search 15 -> index " + Search(15));
    }
}