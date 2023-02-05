
def conversion_base(numero, base):
    """
    Método para convertir un número entero a una base específica.
    :param numero: Número que se desea convertir.
    :param base: Base a la cual se desea hacer la conversión.
    :return: Cadena de texto que representa el número convertido.
    """
    numero = int(numero)
    base = int(base)
    conversion = ''
    while numero // base != 0:
        conversion = str(numero % base) + conversion
        numero = numero // base
    return str(numero) + conversion

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
    numero = input("Ingresa el número entero a convertir: ")

    while not validar_entero(numero):
        print("El número ingresado no es entero, por favor ingresar un número entero: ")
        numero = input("Ingresa el número entero a convertir: ")

    base = input("Ingresa la base a la cuál se quiere hacer la conversión, debe ser un número entero: ")

    while not validar_entero(base):
        print("El número ingresado no es entero, por favor ingresar un número entero: ")
        base = input("Ingresa la base a la cuál se quiere hacer la conversión, debe ser un número entero: ")

    result = conversion_base(numero, base)
    print("El resultado de la conversion es " + f'{result}')



