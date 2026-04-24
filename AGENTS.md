# Codex Review Rules for CodexReviewDemo

This is an ASP.NET Core 10 Web API project.

## Review Focus

### Code Quality
- Clean and readable code
- Meaningful names
- Small methods
- Avoid duplicate logic

### C#
- Use async/await correctly
- Avoid async void
- Use dependency injection
- Nullable warnings should be fixed

### API
- Proper HTTP verbs
- Correct status codes
- Validate request models
- Use DTOs when needed

### Security
- No secrets in code
- Validate input
- Prevent SQL Injection
- Use authorization where required

### Performance
- Avoid unnecessary database calls
- Avoid loading large data unnecessarily

### Testing
- Suggest unit tests for business logic

## Review Style

Only report real issues.
Be concise.
Suggest corrected code when useful.