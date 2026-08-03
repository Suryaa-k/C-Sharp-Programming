using System;

class NestedList {
    private int[][] rows;
    private int rowCount;
    private int rowCapacity;

    public NestedList() {
        rowCapacity = 2;
        rowCount = 0;
        rows = new int[rowCapacity][];
    }

    private void Resize() {
        rowCapacity *= 2;
        int[][] newRows = new int[rowCapacity][];
        for (int i = 0; i < rowCount; i++) newRows[i] = rows[i];
        rows = newRows;
    }

    public void AddRow(int[] arr) {
        if (rowCount == rowCapacity) Resize();
        int[] newRow = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++) newRow[i] = arr[i];
        rows[rowCount++] = newRow;
    }

    public int Get(int row, int col) { return rows[row][col]; }
    public void Set(int row, int col, int value) { rows[row][col] = value; }

    public void Traverse() {
        for (int i = 0; i < rowCount; i++) {
            for (int j = 0; j < rows[i].Length; j++) Console.Write(rows[i][j] + " ");
            Console.WriteLine();
        }
    }

    public int[] Flatten() {
        int total = 0;
        for (int i = 0; i < rowCount; i++) total += rows[i].Length;
        int[] flat = new int[total];
        int idx = 0;
        for (int i = 0; i < rowCount; i++)
            for (int j = 0; j < rows[i].Length; j++)
                flat[idx++] = rows[i][j];
        return flat;
    }
}

class Program {
    static void Main() {
        NestedList nl = new NestedList();
        nl.AddRow(new int[] {1, 2, 3});
        nl.AddRow(new int[] {4, 5});
        nl.AddRow(new int[] {6, 7, 8, 9});

        nl.Traverse();

        Console.WriteLine("Get(2,1) = " + nl.Get(2, 1));
        nl.Set(0, 0, 99);
        nl.Traverse();

        int[] flat = nl.Flatten();
        Console.Write("Flattened: ");
        foreach (int v in flat) Console.Write(v + " ");
        Console.WriteLine();
    }
}