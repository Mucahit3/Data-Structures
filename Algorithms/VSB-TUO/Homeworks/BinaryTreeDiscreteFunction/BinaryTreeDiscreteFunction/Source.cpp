#include <iostream>
#include "Node.h"
#include "BinaryTree.h"

using namespace std;

void tree_insert(BinaryTree &T, Node *z);
void tree_delete(BinaryTree &T, Node *z);
Node* tree_min(Node *v);
Node* tree_max(Node *v);
Node* tree_search(Node *v, int e);
Node* tree_successor(Node *v);

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

	tree_insert(binaryTree, root);
	tree_insert(binaryTree, item1);
	tree_insert(binaryTree, item2);
	tree_insert(binaryTree, item3);
	tree_insert(binaryTree, item4);
	tree_insert(binaryTree, item5);
	tree_insert(binaryTree, item6);
	tree_insert(binaryTree, item7);
	tree_insert(binaryTree, item8);
	tree_insert(binaryTree, item9);
	tree_insert(binaryTree, item10);
	tree_insert(binaryTree, item11);
	tree_insert(binaryTree, item12);
	tree_insert(binaryTree, item13);
	tree_insert(binaryTree, item14);

	
	//cout << "Preorder Traversal :" << endl;
	//binaryTree.preorder(binaryTree.root);
	//cout << endl << endl;
	//
	//cout << "Inorder Traversal :" << endl;
	//binaryTree.inorder(binaryTree.root);
	//cout << endl << endl;
	//
	//cout << "Postorder Traversal :" << endl;
	//binaryTree.postorder(binaryTree.root);
	//cout << endl << endl;
	
	cout << "Minimum value in Tree :" << endl;
	temp = tree_min(binaryTree.root);
	cout << temp->elt << endl << endl;
	
	cout << "Maximum value in Tree :" << endl;
	temp = tree_max(binaryTree.root);
	cout << temp->elt << endl << endl;
	
	cout << "Search in tree :" << endl;
	cout << tree_search(binaryTree.root, 20) << endl << endl;
	
	cout << "Successor of the term in tree :" << endl;
	temp = tree_successor(item4);
	cout << temp->elt << endl << endl;
	cout << tree_successor(item9) << endl << endl;
	cout << tree_successor(binaryTree.root) << endl << endl;
	
	temp = tree_search(binaryTree.root, 2);
	tree_delete(binaryTree, temp);

	cout << "After deletions the tree :" << endl;
	binaryTree.inorder(binaryTree.root);
	cout << endl << endl;

}

// Insert item to the tree
void tree_insert(BinaryTree &T, Node *z)
{
	Node *y = NULL;
	Node *x = T.root;


	while (x != NULL)
	{
		y = x;
		if (z->elt < x->elt) x = x->left;
		else				 x = x->right;
	}

	z->par = y;

	if (y == NULL)				T.root = z;
	else if (z->elt < y->elt)	y->left = z;
	else						y->right = z;
}

// Delete item from the tree
void tree_delete(BinaryTree &T, Node *z)
{
	Node *y, *x;

	if (z->left == NULL || z->right == NULL) y = z;
	else									 y = tree_successor(z);

	if (y->left != NULL) x = y->left;
	else				 x = y->right;

	if (x != NULL) x->par = y->par;

	if (y->par == NULL)			T.root = x;
	else if (y = y->par->left)	y->par->left = x;
	else						y->par->right = x;

	if (y != z)
		z->elt = y->elt;
}

// Min term in tree
Node* tree_min(Node *v)
{
	while (v->left != NULL) v = v->left;

	return v;
}

// Max term in tree
Node* tree_max(Node *v)
{
	while (v->right != NULL) v = v->right;

	return v;
}

// Search in tree
Node* tree_search(Node *v, int e)
{
	if (v == NULL || v->elt == e) return v;

	if (e < v->elt) return tree_search(v->left, e);
	else			return tree_search(v->right, e);
}

Node* tree_successor(Node *v)
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