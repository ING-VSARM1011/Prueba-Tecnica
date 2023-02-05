
def division_enteros(numero1, numero2):
    """
    Método para obtener el resultado de la división de dos números enteros.
    :param numero1: Primer número entero.
    :param numero2: Segundo número entero.
    :return: Resultado de la división del primer número entero entre el segundo.
    """
    return int(numero1) / int(numero2)

def validar_entero(numero):
    """
    Método para validar que el usuario ha ingresado un número entero.
    :param numero: número entero ingresado.
    :return: Resultado de la validación
    """
    try:
        int(numero)
        validacion = True
    except ValueError:
        validacion = False

    return validacion

if __name__ == "__main__":
    primer_numero = input("Ingresa un número entero: ")

    while not validar_entero(primer_numero):
        print("El número ingresado no es entero, por favor ingresar un número entero: ")
        primer_numero = input("Ingresa un número entero: ")

    segundo_numero = input("Ingresa otro número entero: ")

    while not validar_entero(segundo_numero):
        print("El número ingresado no es entero, por favor ingresar un número entero: ")
        segundo_numero = input("Ingresa otro un número entero: ")

    division = division_enteros(primer_numero, segundo_numero)
    print("El resultado de la división de los enteros ingresado es " + f'{division}')



