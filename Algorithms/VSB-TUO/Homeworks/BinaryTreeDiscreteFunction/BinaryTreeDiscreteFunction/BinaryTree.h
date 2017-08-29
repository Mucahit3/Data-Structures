#pragma once
#include "Node.h"

class BinaryTree
{
public:

	Node *root;									// pointer to the root
	int n;										// number of nodes

	BinaryTree();								// constructor

	void preorder(Node *v);						// preorder traversal
	void inorder(Node *v);						// inorder traversal
	void postorder(Node *v);					// postorder traversal

};

