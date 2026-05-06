# Zenith Sim Scheduler Lab Walkthrough

This note is the quickest way to read the extra review model in `zenith-sim-scheduler-lab`.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | input pressure | 166 | ship |
| stress | state drift | 161 | ship |
| edge | review cost | 159 | ship |
| recovery | decision risk | 186 | ship |
| stale | input pressure | 248 | ship |

Start with `stale` and `edge`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

`stale` is the optimistic case; use it to make sure the scoring path still rewards strong signal.
