# zenith-sim-scheduler-lab

`zenith-sim-scheduler-lab` explores simulations with a small C# codebase and local fixtures. The technical goal is to create a C# reference implementation for scheduler workflows, centered on constraint solving, bounded scenario files, and conflict explanations.

## Use Case

The project exists to keep a narrow engineering decision visible and testable. For this repo, that decision is how input pressure and review cost should influence a review result.

## Zenith Sim Scheduler Lab Review Notes

Start with `input pressure` and `review cost`. Those cases create the widest score spread in this repo, so they are the best quick check when the model changes.

## Highlights

- `fixtures/domain_review.csv` adds cases for input pressure and state drift.
- `metadata/domain-review.json` records the same cases in structured form.
- `config/review-profile.json` captures the read order and the two review questions.
- `examples/zenith-sim-scheduler-walkthrough.md` walks through the case spread.
- The C# code includes a review path for `input pressure` and `review cost`.
- `docs/field-notes.md` explains the strongest and weakest cases.

## Code Layout

The implementation keeps the scoring rule plain: reward signal and confidence, preserve slack, penalize drag, then classify the result into a review lane.

The C# code keeps the review rule close to the tests.

## Run The Check

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

## Regression Path

That command is also the regression path. It verifies the domain cases and catches mismatches between the CSV, metadata, and code.

## Future Work

This remains a local project with deterministic fixtures. It does not depend on credentials, hosted services, or live data. Future work should add richer malformed inputs before widening the public API.
