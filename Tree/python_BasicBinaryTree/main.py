from basic_binary_tree import BinaryTree, Node

# Create a small tree
small_tree = BinaryTree.small_tree()

# Print its depth
print("Depth of small tree:", small_tree.depth())

# Check if it's full
print("Is small tree full?", small_tree.is_full())

# Create a medium tree
medium_tree = BinaryTree.medium_tree()

# Iterate over its nodes
for node_value in medium_tree:
    print(node_value)
