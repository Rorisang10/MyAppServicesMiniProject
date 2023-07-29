document.getElementById('addSupplierForm').addEventListener('submit', async (e) => {
    e.preventDefault();

    const companyName = document.getElementById('companyName').value;
    const telephoneNo = document.getElementById('telephoneNo').value;

    if (!companyName || !telephoneNo) {
        alert('Please fill in all fields.');
        return;
    }

    try {
        const response = await fetch('https://localhost:port/api/supplier', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({
                companyName,
                telephoneNo,
            }),
        });

        if (!response.ok) {
            alert('Failed to add supplier. Please try again.');
            return;
        }

        alert('Supplier added successfully.');
        document.getElementById('addSupplierForm').reset();
    } catch (error) {
        alert('An error occurred while processing your request.');
    }
});

document.getElementById('searchSupplierForm').addEventListener('submit', async (e) => {
    e.preventDefault();

    const searchCompanyName = document.getElementById('searchCompanyName').value;

    if (!searchCompanyName) {
        alert('Please enter a company name to search.');
        return;
    }

    try {
        const response = await fetch(`https://localhost:port/api/supplier/${searchCompanyName}`);

        if (!response.ok) {
            alert('Failed to search for supplier. Please try again.');
            return;
        }

        const data = await response.json();
        if (data) {
            document.getElementById('result').innerText = `Company Name: ${data.companyName}, Telephone No: ${data.tele

        const data = await response.json();
            if (data) {
                document.getElementById('result').innerText = `Company Name: ${data.companyName}, Telephone No: ${data.telephoneNo}`;
            } else {
                document.getElementById('result').innerText = 'Supplier not found.';
            }
        } catch (error) {
            alert('An error occurred while processing your request.');
        }
    });
