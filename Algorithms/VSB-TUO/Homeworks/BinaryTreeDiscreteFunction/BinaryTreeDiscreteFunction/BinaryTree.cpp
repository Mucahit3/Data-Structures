#include "BinaryTree.h"
#include<iostream>

using namespace std;

BinaryTree::BinaryTree()							// constructor
	: root(NULL), n(0) { }


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




