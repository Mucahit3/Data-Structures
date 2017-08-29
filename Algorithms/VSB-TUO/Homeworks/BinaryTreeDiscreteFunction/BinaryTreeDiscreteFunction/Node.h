#pragma once
class Node										// a node of the tree
{
public:

	int     elt;								// element value
	Node	*par;								// parent
	Node	*left;								// left child
	Node	*right;								// right child

	Node();
};

