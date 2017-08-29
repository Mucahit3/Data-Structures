#include <iostream>
using namespace std;

class Node										// a node of the tree
{
public:

	int    elt;									// element value
	Node*   par;								// parent
	Node*   left;								// left child
	Node*   right;								// right child

	Node()										// constructor
	{
		elt = 0;
		par = NULL;
		left = NULL;
		right = NULL;
	}
};

class BinaryTree
{
public:
	Node *root;									// pointer to the root
	int n;										// number of nodes

	BinaryTree();								// constructor

	void preorder(Node *v);						// preorder traversal
	void inorder(Node *v);						// inorder traversal
	void postorder(Node *v);					// postorder traversal

	Node* tree_min(Node *v);
	Node* tree_max(Node *v);

	Node* tree_search(Node *v, int e);
	Node* tree_successor(Node *v);

	void tree_insert(Node *z);
	void tree_delete(Node *z);
};

BinaryTree::BinaryTree()							// constructor
	: root(NULL), n(0) { }


// Insert item to the tree
void BinaryTree::tree_insert(Node *z)
{
	Node *y = NULL;
	Node *x = this->root;


	while (x != NULL)
	{
		y = x;
		if (z->elt < x->elt) x = x->left;
		else				 x = x->right;
	}

	z->par = y;

	if (y == NULL)				this->root = z;
	else if (z->elt < y->elt)	y->left = z;
	else						y->right = z;
}

// Delete item from the tree
void BinaryTree::tree_delete(Node *z)
{
	Node *y, *x;

	if (z->left == NULL || z->right == NULL) y = z;
	else									 y = tree_successor(z);

	if (y->left != NULL) x = y->left;
	else				 x = y->right;

	if (x != NULL) x->par = y->par;

	if (y->par == NULL)			this->root = x;
	else if (y = y->par->left)	y->par->left = x;
	else						y->par->right = x;

	if (y != z)
		z->elt = y->elt;
}

// Preorder traversal
void BinaryTree::preorder(Node* v)
{
	cout << v->elt << " ";

	if (v->left != NULL)		preorder(v->left);

	if (v->right != NULL)		preorder(v->right);
}

// Inorder traversal
void BinaryTree::inorder(Node* v)
{
	if (v->left != NULL)		inorder(v->left);

	cout << v->elt << " ";

	if (v->right != NULL)		inorder(v->right);

}

// Postorder traversal
void BinaryTree::postorder(Node* v)
{
	if (v->left != NULL)		postorder(v->left);

	if (v->right != NULL)		postorder(v->right);

	cout << v->elt << " ";
}

// Min term in tree
Node* BinaryTree::tree_min(Node *v)
{
	while (v->left != NULL) v = v->left;

	return v;
}

// Max term in tree
Node* BinaryTree::tree_max(Node *v)
{
	while (v->right != NULL) v = v->right;

	return v;
}

// Search in tree
Node* BinaryTree::tree_search(Node *v, int e)
{
	if (v == NULL || v->elt == e) return v;

	if (e < v->elt) return tree_search(v->left, e);
	else			return tree_search(v->right, e);
}

Node* BinaryTree::tree_successor(Node *v)
{
	Node *successor;
	if (v->right != NULL) return tree_min(v->right);

	successor = v->par;

	while (successor != NULL && v == successor->right)
	{
		v = successor;
		successor = successor->par;
	}

	return successor;
}

int main()
{
	BinaryTree binaryTree;
	Node *temp;

	Node *root = new Node;
	root->elt = 16;
	Node *item1 = new Node();
	item1->elt = 8;
	Node *item2 = new Node();
	item2->elt = 24;
	Node *item3 = new Node();
	item3->elt = 4;
	Node *item4 = new Node();
	item4->elt = 12;
	Node *item5 = new Node();
	item5->elt = 20;
	Node *item6 = new Node();
	item6->elt = 28;
	Node *item7 = new Node();
	item7->elt = 2;
	Node *item8 = new Node();
	item8->elt = 6;
	Node *item9 = new Node();
	item9->elt = 10;
	Node *item10 = new Node();
	item10->elt = 14;
	Node *item11 = new Node();
	item11->elt = 18;
	Node *item12 = new Node();
	item12->elt = 22;
	Node *item13 = new Node();
	item13->elt = 26;
	Node *item14 = new Node();
	item14->elt = 30;

	binaryTree.tree_insert(root);
	binaryTree.tree_insert(item1);
	binaryTree.tree_insert(item2);
	binaryTree.tree_insert(item3);
	binaryTree.tree_insert(item4);
	binaryTree.tree_insert(item5);
	binaryTree.tree_insert(item6);
	binaryTree.tree_insert(item7);
	binaryTree.tree_insert(item8);
	binaryTree.tree_insert(item9);
	binaryTree.tree_insert(item10);
	binaryTree.tree_insert(item11);
	binaryTree.tree_insert(item12);
	binaryTree.tree_insert(item13);
	binaryTree.tree_insert(item14);


	//cout << "Preorder Traversal :" << endl;
	//binaryTree.preorder(binaryTree.root);
	//cout << endl << endl;

	//cout << "Inorder Traversal :" << endl;
	//binaryTree.inorder(binaryTree.root);
	//cout << endl << endl;

	//cout << "Postorder Traversal :" << endl;
	//binaryTree.postorder(binaryTree.root);
	//cout << endl << endl;

	//cout << "Minimum value in Tree :" << endl;
	//temp = binaryTree.tree_min(binaryTree.root);
	//cout << temp->elt << endl << endl;

	//cout << "Maximum value in Tree :" << endl;
	//temp = binaryTree.tree_max(binaryTree.root);
	//cout << temp->elt << endl << endl;

	//cout << "Search in tree :" << endl;
	//cout << binaryTree.tree_search(binaryTree.root, 20) << endl << endl;

	/*cout << "Successor of the term in tree :" << endl;
	temp = binaryTree.tree_successor(item4);
	cout << temp->elt << endl << endl;*/
	//cout << binaryTree.tree_successor(item9) << endl << endl;
	//cout << binaryTree.tree_successor(binaryTree.root) << endl << endl;
	
	/*temp = binaryTree.tree_search(binaryTree.root, 24);
	binaryTree.tree_delete(temp);

	cout << "After deletions the tree :" << endl;
	binaryTree.inorder(binaryTree.root);
	cout << endl << endl;*/

}