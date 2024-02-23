import pytest

from basic_binary_tree import Node, BinaryTree


def test_node_iteration():
    node = Node(1, Node(2), Node(3))
    assert list(node) == [2, 1, 3]


def test_node_length():
    node = Node(1, Node(2), Node(3))
    assert len(node) == 3


def test_node_is_full():
    full_node = Node(1)
    partial_node = Node(1, Node(2))
    assert full_node.is_full() is True
    assert partial_node.is_full() is False


def test_binary_tree_iteration():
    tree = BinaryTree.small_tree()
    assert list(tree) == [1, 2, 3]


def test_binary_tree_length():
    tree = BinaryTree.small_tree()
    assert len(tree) == 3


def test_binary_tree_depth():
    tree = BinaryTree(Node(4))
    assert tree.depth() == 1
    tree = BinaryTree.small_tree()
    assert tree.depth() == 2
    tree = BinaryTree.medium_tree()
    assert tree.depth() == 4


def test_binary_tree_is_full():
    tree = BinaryTree(Node(1))
    assert tree.is_full() is True
    tree = BinaryTree.small_tree()
    assert tree.is_full() is True
    tree = BinaryTree.medium_tree()
    assert tree.is_full() is False
