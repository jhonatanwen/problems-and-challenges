import re


def CodingChallenge(strParam):
    vowels = "aeiouyAEIOUY"
    words = strParam.split(' ')
    translated_words = []

    for word in words:
        if not word:
            continue

        word_match = re.match(r"([a-zA-Z]+)([^a-zA-Z]*)", word)

        if not word_match:
            translated_words.append(word)
            continue

        word_part = word_match.group(1)
        punctuation = word_match.group(2)
        was_capitalized = word_part[0].isupper()

        if word_part[0] in vowels:
            if all(char in vowels for char in word_part):
                translated_word = word_part + "yay"
            else:
                translated_word = word_part + "ay"
        else:
            first_vowel_index = -1

            for i, char in enumerate(word_part):
                if char in vowels:
                    first_vowel_index = i
                    break

            if first_vowel_index == -1:
                translated_word = word_part + "ay"
            else:
                prefix = word_part[:first_vowel_index]
                stem = word_part[first_vowel_index:]
                translated_word = stem + prefix + "ay"

        if was_capitalized:
            translated_word = translated_word.capitalize()

        translated_words.append(translated_word + punctuation)


    translated_string = " ".join(translated_words)

    return translated_string

print(CodingChallenge("ayay pig latin is cool"))