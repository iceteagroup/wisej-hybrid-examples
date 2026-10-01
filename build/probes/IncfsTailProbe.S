// x86_64 Linux/Android syscall-only reproducer for the preserved 2,152,608-byte
// libxamarin-app.so. Map its last partial 16 KB page privately and write into
// the zero-filled tail. This does not write back to the underlying file.
.intel_syntax noprefix
.global _start
.text
_start:
    mov rdi, [rsp + 16]
    xor esi, esi
    xor edx, edx
    mov eax, 2
    syscall
    test rax, rax
    js failed
    mov r8, rax
    xor edi, edi
    mov esi, 0x210000
    mov edx, 3
    mov r10d, 2
    xor r9d, r9d
    mov eax, 9
    syscall
    test rax, rax
    js failed
    mov byte ptr [rax + 0x20fff0], 0
    xor edi, edi
    jmp exit
failed:
    mov edi, 2
exit:
    mov eax, 60
    syscall
