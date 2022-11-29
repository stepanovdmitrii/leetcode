#include <unordered_map>
#include <list>
#include <iostream>

using namespace std;

struct Node {
    int key;
    int value;
};

class LRUCache {
    unordered_map<int, list<Node>::iterator> dict;
    list<Node> nodes;
    int capacity;

public:
    LRUCache(int capacity): capacity(capacity) {
        ios_base::sync_with_stdio(false);
        cin.tie(nullptr);
        cout.tie(nullptr);
    }
   
    int get(int key) {
        auto it = dict.find(key);
        if(it == dict.end()) {
            return -1;
        }

        Node n = *(it->second);
        nodes.erase(it->second);
        nodes.push_front(n);
        dict[key] = nodes.begin();
        
        return n.value;
    }
    
    void put(int key, int value) {
        Node n;
        n.key = key;
        n.value = value;

        auto it = dict.find(key);
        if(it == dict.end()) { //not in cache
            nodes.push_front(n);
            dict[key] = nodes.begin();;
            while(nodes.size() > capacity){
                Node to_drop = nodes.back();
                nodes.pop_back();
                dict.erase(to_drop.key);
            }
            return;
        }

        nodes.erase(it->second);
        nodes.push_front(n);
        dict[key] = nodes.begin();
    }
};

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache* obj = new LRUCache(capacity);
 * int param_1 = obj->get(key);
 * obj->put(key,value);
 */


int main() {
    LRUCache* obj = new LRUCache(2);
    obj->put(1, 0);
    obj->put(2,3);
    cout << obj->get(1) << "\n";
    obj->put(3,3);
    cout << obj->get(2) << "\n";
    obj->put(4,4);
    cout << obj->get(1) << "\n";
    cout << obj->get(3) << "\n";
    cout << obj->get(4) << "\n";
}