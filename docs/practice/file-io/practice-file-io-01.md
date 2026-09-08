# Practice File I/O 01 — "Roster Summary"

Read a text file of `name,score` lines (one student per line). Compute each student's score plus the class average, then write a summary report to a separate output file.

## Self-check
- A missing input file is handled gracefully — return an empty result, don't throw or crash
- Malformed lines (wrong number of fields, non-numeric score) are skipped rather than crashing the whole read
- The output file's content matches the expected summary format exactly, including the class average
- An empty roster still produces a valid (if minimal) output file
