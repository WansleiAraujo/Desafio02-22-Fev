# Escreva um programa que encripta um texto utilizando uma tabela de mapeamento de caracteres, por exemplo:
# a = K, n = J, d = A, r = T, e = L

table = { 'a': 'K', 'b': 'M', 'c': 'P', 'd': 'A', 'e': 'L', 'f': 'Q', 'g': 'U', 'h': 'N', 'i': 'V',
          'j': 'F', 'k': 'U', 'l': 'X', 'm': 'G', 'n': 'J', 'o': 'Y', 'p': 'R', 'q': 'Z', 'r': 'T',
          's': 'B', 't': 'C', 'u': 'H', 'v': 'S', 'w': 'D', 'x': 'I', 'y': 'O', 'z': 'E'}

def encrypt(text, table):
    encrypted_text = ""
    for char in text:
        if char in table:
            encrypted_text += table[char]
        else:
            encrypted_text += char
    return encrypted_text

text = input("Digite um texto para criptografar: ")
encrypted_text = encrypt(text, table)
print(encrypted_text)