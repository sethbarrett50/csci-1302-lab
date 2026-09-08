# Practice Dictionaries 01 — "Word Frequency Counter"

Given a list of words, use a `Dictionary<string, int>` to count how many times each word appears, case-insensitively (`"Apple"`, `"apple"`, and `"APPLE"` should all count as the same word).

## Self-check
- Case is handled consistently — mixed-case repeats of the same word merge into one count
- A word that appears once still shows up with a count of 1
- An empty input produces an empty result, not an error
