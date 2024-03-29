/*
Дано бинарное дерево с выделенным корнем, в каждой вершине которого записано по одной букве A-Z.
Две вершины считаются эквивалентными, если поддеревья этих вершин содержат одинаковое множество (т.е. без учета частот) букв.

Нужно найти две эквивалентные вершины с максимальным суммарным размером поддеревьев.

      A
    /   \
   C     B
  / \   / \
  A D   A  D
 /          \
B            C


*/

/*
C -> ABCD       B -> ABCD
A -> AB         A -> A
B -> B          D -> CD
D -> D          C -> C
        A -> ABCD
        
        
        https://en.cppreference.com/w/cpp/container/set/insert
*/