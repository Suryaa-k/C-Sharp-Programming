using System;

class MyList {
    private int[] data;
    private int size;
    private int capacity;

    public MyList() {
        capacity = 2;
        size = 0;
        data = new int[capacity];
    }

    private void Resize() {
        capacity *= 2;
        int[] newData = new int[capacity];
        for (int i = 0; i < size; i++) newData[i] = data[i];
        data = newData;
    }

    public void Append(int value) {
        if (size == capacity) Resize();
        data[size++] = value;
    }

    public void Insert(int index, int value) {
        if (index < 0 || index > size) return;
        if (size == capacity) Resize();
        for (int i = size; i > index; i--) data[i] = data[i - 1];
        data[index] = value;
        size++;
    }

    public int IndexOf(int value) {
        for (int i = 0; i < size; i++) if (data[i] == value) return i;
        return -1;
    }

    public void RemoveValue(int value) {
        int idx = IndexOf(value);
        if (idx == -1) return;
        for (int i = idx; i < size - 1; i++) data[i] = data[i + 1];
        size--;
    }

    public int Pop(int index) {
        if (index < 0 || index >= size) return -1;
        int val = data[index];
        for (int i = index; i < size - 1; i++) data[i] = data[i + 1];
        size--;
        return val;
    }

    public void Reverse() {
        int left = 0, right = size - 1;
        while (left < right) {
            int temp = data[left];
            data[left] = data[right];
            data[right] = temp;
            left++; right--;
        }
    }

    public bool IsEmpty() { return size == 0; }
    public int Size() { return size; }

    public void Print() {
        for (int i = 0; i < size; i++) Console.Write(data[i] + " ");
        Console.WriteLine();
    }
}

class Program {
    static void Main() {
        MyList l = new MyList();
        l.Append(10); l.Append(20); l.Append(30);
        l.Print();

        l.Insert(1, 15);
        l.Print();

        l.RemoveValue(20);
        l.Print();

        int popped = l.Pop(0);
        Console.WriteLine("Popped: " + popped);
        l.Print();

        l.Reverse();
        l.Print();

        Console.WriteLine("Size: " + l.Size() + ", Empty: " + l.IsEmpty());
    }
}